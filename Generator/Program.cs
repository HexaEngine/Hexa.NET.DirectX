using HexaGen;
using HexaGen.Patching;

#if DX
BatchGenerator generator = new();
generator
    .Start()
    .AddGlobalPrePatch(new NamingPatch(["DXGI", "D3D11On12", "D3D111", "D3D11", "D3D12", "Dxc", "D3D"], NamingPatchOptions.CaseInsensitive, NamingPatchMode.All))

    .Setup<CsComCodeGenerator>("d3dcommon/generator.json")
    .Generate(["d3dcommon/d3dcommon.h"], "../../../../Hexa.NET.D3DCommon/Generated")
    .GetConfig(out var config)
    .GetMetadata(out var metadata)

    .Setup<CsComCodeGenerator>("dxgi/generator.json")
    .MergeConfig(config, MergeOptions.Mappings)
    .CopyFromMetadata(metadata)
    .Generate([.. Directory.GetFiles("dxgi", "*.h")], "../../../../Hexa.NET.DXGI/Generated")
    .GetConfig(out config)

    .Setup<CsComCodeGenerator>("d3d11/generator.json")
    .MergeConfig(config, MergeOptions.Mappings)
    .CopyFromMetadata(metadata)
    .Generate([.. Directory.GetFiles("d3d11", "*.h")], "../../../../Hexa.NET.D3D11/Generated")
    .GetConfig(out var d3d11Config)
    .GetMetadata(out var d3d11Metadata)

    .Setup<CsComCodeGenerator>("d3d12/generator.json")
    .MergeConfig(config, MergeOptions.Mappings)
    .CopyFromMetadata(metadata)
    .AlterConfig(c =>
    {
        c.TypeMappings.Add("D3D11On12CreatorID", "D3D11On12CreatorID");
        c.TypeMappings.Add("D3D9On12CreatorID", "D3D9On12CreatorID");
        c.ClassMappings.Add(new("D3D11On12CreatorID", "D3D11On12CreatorID", null));
        c.ClassMappings.Add(new("D3D9On12CreatorID", "D3D9On12CreatorID", null));

        c.TypeMappings.Add("D3D11_RESOURCE_FLAGS", "D3D11ResourceFlags");
        c.ClassMappings.Add(new("D3D11_RESOURCE_FLAGS", "D3D11ResourceFlags", null));
        c.TypeMappings.Add("D3D12_RESOURCE_FLAGS", "D3D12ResourceFlags");
        c.ClassMappings.Add(new("D3D12_RESOURCE_FLAGS", "D3D12ResourceFlags", null));
    })
    .Generate([.. Directory.GetFiles("d3d12", "*.h")], "../../../../Hexa.NET.D3D12/Generated")
    .GetConfig(out var d3d12Config)
    .GetMetadata(out var d3d12Metadata)

    .Setup<CsComCodeGenerator>("d3d11on12/generator.json")
    .MergeConfig(config, MergeOptions.Mappings)
    .MergeConfig(d3d11Config, MergeOptions.Mappings)
    .MergeConfig(d3d12Config, MergeOptions.Mappings)
    .AlterGenerator(g =>
    {
        var meta = metadata.Clone();
        meta.Merge(d3d11Metadata, new HexaGen.Metadata.MergeOptions());
        meta.Merge(d3d12Metadata, new HexaGen.Metadata.MergeOptions());
        g.CopyFrom(meta);
    })
    .Generate([.. Directory.GetFiles("d3d11on12", "*.h")], "../../../../Hexa.NET.D3D11On12/Generated")

    .Setup<CsComCodeGenerator>("d3dcompiler/generator.json")
    .MergeConfig(d3d11Config, MergeOptions.Mappings)
    .Generate(["d3dcompiler/d3dcompiler.h"], "../../../../Hexa.NET.D3DCompiler/Generated")

    .Setup<CsComCodeGenerator>("dxc/generator.json")
    .MergeConfig(config, MergeOptions.Mappings)
    .Generate(["dxc/main.h"], "../../../../Hexa.NET.DXC/Generated");
#endif
BatchGenerator generator2 = new();
generator2
    .Start()
    .AddGlobalPrePatch(new NamingPatch(["XAudio2", "X3DAudio"], NamingPatchOptions.CaseInsensitive, NamingPatchMode.Functions | NamingPatchMode.Enums))

    .Setup<CsComCodeGenerator>("xaudio2/generator.json")
    .Generate([.. Directory.GetFiles("xaudio2", "*.h")], "../../../../Hexa.NET.XAudio2/Generated")

    .Setup<CsComCodeGenerator>("xd3audio/generator.json")
    .AlterGenerator(g =>
    {
        g.FunctionTableBuilder.Add("X3DAudioInitialize");
    })
    .Generate(["xd3audio/main.h"], "../../../../Hexa.NET.X3DAudio/Generated")

    .Finish();