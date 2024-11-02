using HexaGen;
using HexaGen.Patching;

var start = DateTime.Now;
Generate(["d3dcommon/d3dcommon.h"], "../../../../Hexa.NET.D3DCommon/Generated", "d3dcommon/generator.json");
Generate(["d3dcompiler/d3dcompiler.h"], "../../../../Hexa.NET.D3DCompiler/Generated", "d3dcompiler/generator.json");
Generate(["dxc/main.h"], "../../../../Hexa.NET.DXC/Generated", "dxc/generator.json");
Generate([.. Directory.GetFiles("d3d11", "*.h")], "../../../../Hexa.NET.D3D11/Generated", "d3d11/generator.json");
Generate([.. Directory.GetFiles("d3d12", "*.h")], "../../../../Hexa.NET.D3D12/Generated", "d3d12/generator.json");
var end = DateTime.Now;
var elapsed = end - start;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"All Done! Generation took {elapsed.TotalSeconds:n2}s");
Console.ForegroundColor = ConsoleColor.White;

static void Generate(List<string> sources, string output, string configPath)
{
    CsCodeGeneratorConfig config = CsCodeGeneratorConfig.Load(configPath);
    CsComCodeGenerator generator = new(config);
    generator.Settings.FunctionNamingConvention = NamingConvention.Unknown;
    generator.Settings.ExtensionNamingConvention = NamingConvention.Unknown;
    generator.PatchEngine.RegisterPrePatch(new NamingPatch(["DXGI", "D3D11", "D3D12", "Dxc", "D3D"], NamingPatchOptions.None));
    generator.LogToConsole();
    generator.Generate(sources, output);
}