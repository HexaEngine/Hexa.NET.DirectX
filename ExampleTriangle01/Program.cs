// See https://aka.ms/new-console-template for more information

using Example;
using Hexa.NET.D3D11;
using Hexa.NET.D3DCommon;
using Hexa.NET.D3DCompiler;
using Hexa.NET.DXGI;
using Hexa.NET.GLFW;
using HexaGen.Runtime;
using HexaGen.Runtime.COM;
using System.Numerics;
using System.Runtime.CompilerServices;

GLFW.Init();

GLFW.WindowHint(GLFW.GLFW_CLIENT_API, GLFW.GLFW_NO_API);

GLFW.WindowHint(GLFW.GLFW_FOCUSED, 1);    // Make window focused on start
GLFW.WindowHint(GLFW.GLFW_RESIZABLE, 1);  // Make window resizable

GLFWwindowPtr window = GLFW.CreateWindow(800, 600, "D3D11 Example", null, null);
if (window.IsNull)
{
    Console.WriteLine("Failed to create GLFW window.");
    GLFW.Terminate();
    return;
}

unsafe IDXGIAdapter1* GetHardwareAdapter(ComPtr<IDXGIFactory2> dxgiFactory)
{
    ComPtr<IDXGIAdapter1> adapter = null;
    dxgiFactory.QueryInterface(out ComPtr<IDXGIFactory6> factory6);

    if (factory6.Handle != null)
    {
        for (uint adapterIndex = 0;
            (ResultCode)factory6.EnumAdapterByGpuPreference(adapterIndex, DxgiGpuPreference.HighPerformance, out adapter) !=
            ResultCode.DXGI_ERROR_NOT_FOUND;
            adapterIndex++)
        {
            DxgiAdapterDesc1 desc;
            adapter.GetDesc1(&desc);
            if (((DxgiAdapterFlag)desc.Flags & DxgiAdapterFlag.Software) != DxgiAdapterFlag.None)
            {
                // Don't select the Basic Render Driver adapter.
                adapter.Release();
                continue;
            }

            return adapter;
        }

        factory6.Release();
    }

    if (adapter.Handle == null)
    {
        for (uint adapterIndex = 0;
            (ResultCode)dxgiFactory.EnumAdapters1(adapterIndex, &adapter.Handle) != ResultCode.DXGI_ERROR_NOT_FOUND;
            adapterIndex++)
        {
            DxgiAdapterDesc1 desc;
            adapter.GetDesc1(&desc);
            string name = new(&desc.Description_0);

            Console.WriteLine($"Found Adapter {name}");

            if (((DxgiAdapterFlag)desc.Flags & DxgiAdapterFlag.Software) != DxgiAdapterFlag.None)
            {
                // Don't select the Basic Render Driver adapter.
                adapter.Release();
                continue;
            }

            return adapter;
        }
    }

    return adapter;
}

unsafe
{
    ComPtr<IDXGIFactory2> dxgiFactory;
    ComPtr<IDXGIAdapter1> dxgiAdapter;

    ComPtr<ID3D11Device1> device;
    ComPtr<ID3D11DeviceContext1> deviceContext;

    D3DFeatureLevel level;

    DXGI.CreateDXGIFactory2(0, out dxgiFactory);

    dxgiAdapter = GetHardwareAdapter(dxgiFactory);

    D3DFeatureLevel[] levelsArr =
    [
        D3DFeatureLevel.Level111,
                D3DFeatureLevel.Level110
    ];

    D3D11CreateDeviceFlag flags = D3D11CreateDeviceFlag.BgraSupport;
    bool debug = true;
    if (debug)
    {
        flags |= D3D11CreateDeviceFlag.Debug;
    }

    ID3D11Device* tempDevice;
    ID3D11DeviceContext* tempContext;

    D3DFeatureLevel* levels = (D3DFeatureLevel*)Unsafe.AsPointer(ref levelsArr[0]);

    D3D11.CreateDevice((IDXGIAdapter*)dxgiAdapter.Handle, D3DDriverType.Unknown, nint.Zero, (uint)flags, levels, (uint)levelsArr.Length, D3D11.D3D11_SDK_VERSION, &tempDevice, &level, &tempContext);

    tempDevice->QueryInterface(out device);
    tempContext->QueryInterface(out deviceContext);

    tempDevice->Release();
    tempContext->Release();

    ComPtr<IDXGISwapChain1> swapChain = default;
    DxgiSwapChainDesc1 swapChainDesc;

    ComPtr<ID3D11RenderTargetView> swapChainRTV;

    int width = 0;
    int height = 0;
    D3D11Viewport Viewport;

    GLFW.GetWindowSize(window, ref width, ref height);

    var Hwnd = GLFW.GetWin32Window(window);

    DxgiSwapChainDesc1 desc = new()
    {
        Width = (uint)width,
        Height = (uint)height,
        Format = DxgiFormat.B8G8R8A8Unorm,
        BufferCount = 3,
        BufferUsage = (uint)DXGI.DXGI_USAGE_RENDER_TARGET_OUTPUT,
        SampleDesc = new(1, 0),
        Scaling = DxgiScaling.Stretch,
        SwapEffect = DxgiSwapEffect.FlipSequential,
        Flags = (uint)(DxgiSwapChainFlag.AllowModeSwitch | DxgiSwapChainFlag.AllowTearing)
    };

    DxgiSwapChainFullscreenDesc fullscreenDesc = new()
    {
        Windowed = 1,
        RefreshRate = new DxgiRational(0, 1),
        Scaling = DxgiModeScaling.Unspecified,
        ScanlineOrdering = DxgiModeScanlineOrder.Unspecified,
    };

    dxgiFactory.CreateSwapChainForHwnd((IUnknown*)device.Handle, Hwnd, &desc, &fullscreenDesc, (IDXGIOutput*)null, out swapChain);
    // IDXGIFactory.MakeWindowAssociation(Hwnd, 1 << 0);

    {
        swapChainDesc = desc;
        swapChain.GetBuffer(0, out ComPtr<ID3D11Texture2D> swapChainBackbuffer);
        ID3D11RenderTargetView* rtv;
        device.CreateRenderTargetView((ID3D11Resource*)swapChainBackbuffer.Handle, (D3D11RenderTargetViewDesc*)null, &rtv);
        swapChainRTV.Handle = rtv;
        swapChainBackbuffer.Release();
    }

    Viewport = new(0, 0, width, height, maxDepth: 1);

    // Vertex and Pixel Shader source code
    string vertexShaderSource = @"
    struct VSInput {
        float3 position : POSITION;
        float4 color : COLOR;
    };

    struct VSOutput {
        float4 position : SV_POSITION;
        float4 color : COLOR;
    };

    VSOutput main(VSInput input) {
        VSOutput output;
        output.position = float4(input.position, 1.0);
        output.color = input.color;
        return output;
    }
";
    string pixelShaderSource = @"
    struct VSOutput {
        float4 position : SV_POSITION;
        float4 color : COLOR;
    };
    float4 main(VSOutput input) : SV_TARGET {
        return input.color;
    }
";

    CompileShader(vertexShaderSource, "main", "vs_5_0", out var vsBlob);
    CompileShader(pixelShaderSource, "main", "ps_5_0", out var psBlob);

    ComPtr<ID3D11VertexShader> vertexShader = default;
    ComPtr<ID3D11PixelShader> pixelShader = default;

    device.CreateVertexShader(vsBlob.GetBufferPointer(), vsBlob.GetBufferSize(), (ID3D11ClassLinkage*)null, vertexShader.GetAddressOf());
    device.CreatePixelShader(psBlob.GetBufferPointer(), psBlob.GetBufferSize(), (ID3D11ClassLinkage*)null, pixelShader.GetAddressOf());

    static unsafe void CompileShader(string vertexShaderSource, string entrypoint, string profile, out ComPtr<ID3D10Blob> blob)
    {
        blob = default;
        nuint size = (nuint)Utils.GetByteCountUTF8(vertexShaderSource);
        byte* pData = Utils.StringToUTF8Ptr(vertexShaderSource);
        byte* pProfile = Utils.StringToUTF8Ptr(profile);
        byte* pEntrypoint = Utils.StringToUTF8Ptr(entrypoint);
        int pixelShaderBlob = D3DCompiler.Compile(pData, size, (byte*)null, (D3DShaderMacro*)null, (ID3DInclude*)null, pEntrypoint, pProfile, 0, 0, blob.GetAddressOf(), null);
        Utils.Free(pEntrypoint);
        Utils.Free(pProfile);
        Utils.Free(pData);
    }

    ComPtr<ID3D11InputLayout> inputLayout;

    D3D11InputElementDesc[] inputLayoutDesc =
    [
        new D3D11InputElementDesc
        {
            SemanticName = Utils.StringToUTF8Ptr("POSITION"),
            SemanticIndex = 0,
            Format = DxgiFormat.R32G32B32Float,
            InputSlot = 0,
            AlignedByteOffset = 0,
            InputSlotClass = D3D11InputClassification.PerVertexData,
            InstanceDataStepRate = 0
        },
         new D3D11InputElementDesc
        {
            SemanticName = Utils.StringToUTF8Ptr("COLOR"),
            SemanticIndex = 0,
            Format = DxgiFormat.R32G32B32A32Float,
            InputSlot = 0,
            AlignedByteOffset = 12,
            InputSlotClass = D3D11InputClassification.PerVertexData,
            InstanceDataStepRate = 0
        }
    ];

    device.CreateInputLayout(ref inputLayoutDesc[0], 2, vsBlob.GetBufferPointer(), vsBlob.GetBufferSize(), &inputLayout.Handle);

    vsBlob.Release();
    psBlob.Release();

    Vertex[] vertices =
    [
        new Vertex(new(0.0f,0.5f,0.0f), new(0,0,1,1)),
        new Vertex(new(0.5f,-0.5f,0.0f), new(0,1,0,1)),
        new Vertex(new(-0.5f,-0.5f,0.0f), new(1,0,0,1))
    ];
    ComPtr<ID3D11Buffer> vertexBuffer;

    D3D11BufferDesc bufferDesc = new()
    {
        BindFlags = (uint)(D3D11BindFlag.VertexBuffer),
        CPUAccessFlags = 0,
        ByteWidth = (uint)(sizeof(Vertex) * vertices.Length),
        Usage = D3D11Usage.Immutable,
    };

    fixed (Vertex* pVerts = vertices)
    {
        D3D11SubresourceData subresourceData = new(pVerts, (uint)sizeof(Vertex));
        device.CreateBuffer(&bufferDesc, &subresourceData, out vertexBuffer);
    }

    GLFW.SetFramebufferSizeCallback(window, Resized);

    void Resized(GLFWwindow* window, int wwidth, int wheight)
    {
        swapChainRTV.Dispose();

        swapChain.ResizeBuffers(swapChainDesc.BufferCount, (uint)wwidth, (uint)wheight, swapChainDesc.Format, swapChainDesc.Flags);
        width = wwidth;
        height = wheight;
        Viewport = new(0, 0, wwidth, wheight);

        swapChain.GetBuffer(0, out ComPtr<ID3D11Texture2D> swapChainBackbuffer);

        ID3D11RenderTargetView* rtv;
        device.CreateRenderTargetView((ID3D11Resource*)swapChainBackbuffer.Handle, (D3D11RenderTargetViewDesc*)null, &rtv);
        swapChainRTV.Handle = rtv;
        swapChainBackbuffer.Release();
    }

    // Main loop
    while (GLFW.WindowShouldClose(window) == 0)
    {
        // Poll for and process events
        GLFW.PollEvents();

        if (GLFW.GetKey(window, (int)GlfwKey.Escape) == GLFW.GLFW_PRESS)
        {
            GLFW.SetWindowShouldClose(window, 1); // Request to close the window
        }

        Vector4 color = new(1, 0.8f, 0.75f, 1);
        deviceContext.ClearRenderTargetView(swapChainRTV.Handle, (float*)&color);

        ID3D11RenderTargetView* rtv = swapChainRTV.Handle;
        deviceContext.OMSetRenderTargets(1, &rtv, (ID3D11DepthStencilView*)null);
        D3D11Viewport viewport = Viewport;
        deviceContext.RSSetViewports(1, &viewport);

        deviceContext.IASetInputLayout(inputLayout);
        uint stride = (uint)sizeof(Vertex);
        uint offset = 0;
        deviceContext.IASetVertexBuffers(0, 1, &vertexBuffer.Handle, &stride, &offset);
        deviceContext.IASetPrimitiveTopology(D3D11PrimitiveTopology.Trianglelist);

        deviceContext.VSSetShader(vertexShader, (ID3D11ClassInstance**)null, 0);
        deviceContext.PSSetShader(pixelShader, (ID3D11ClassInstance**)null, 0);

        deviceContext.Draw(3, 0);

        swapChain.Present(1, 0);
    }

    vertexBuffer.Release();
    pixelShader.Release();
    vertexShader.Release();
    inputLayout.Release();
    swapChainRTV.Release();
    swapChain.Release();
    device.Release();
    deviceContext.Release();
    dxgiAdapter.Release();
    dxgiFactory.Release();
}

// Clean up and terminate GLFW
GLFW.DestroyWindow(window);
GLFW.Terminate();