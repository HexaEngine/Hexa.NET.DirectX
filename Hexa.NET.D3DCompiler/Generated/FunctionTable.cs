// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using Hexa.NET.D3DCommon;
using Hexa.NET.D3D11;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3DCompiler
{
	public unsafe partial class D3DCompiler
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, automatically called. Do not call manually, only after <see cref="FreeApi"/>.
		/// </summary>
		public static void InitApi()
		{
			funcTable = new FunctionTable(LibraryLoader.LoadLibrary(GetLibraryName, null), 25);
			funcTable.Load(0, "D3DReadFileToBlob");
			funcTable.Load(1, "D3DWriteBlobToFile");
			funcTable.Load(2, "D3DCompile");
			funcTable.Load(3, "D3DCompile2");
			funcTable.Load(4, "D3DCompileFromFile");
			funcTable.Load(5, "D3DPreprocess");
			funcTable.Load(6, "D3DGetDebugInfo");
			funcTable.Load(7, "D3DReflect");
			funcTable.Load(8, "D3DReflectLibrary");
			funcTable.Load(9, "D3DDisassemble");
			funcTable.Load(10, "D3DDisassembleRegion");
			funcTable.Load(11, "D3DCreateLinker");
			funcTable.Load(12, "D3DLoadModule");
			funcTable.Load(13, "D3DCreateFunctionLinkingGraph");
			funcTable.Load(14, "D3DGetTraceInstructionOffsets");
			funcTable.Load(15, "D3DGetInputSignatureBlob");
			funcTable.Load(16, "D3DGetOutputSignatureBlob");
			funcTable.Load(17, "D3DGetInputAndOutputSignatureBlob");
			funcTable.Load(18, "D3DStripShader");
			funcTable.Load(19, "D3DGetBlobPart");
			funcTable.Load(20, "D3DSetBlobPart");
			funcTable.Load(21, "D3DCreateBlob");
			funcTable.Load(22, "D3DCompressShaders");
			funcTable.Load(23, "D3DDecompressShaders");
			funcTable.Load(24, "D3DDisassemble10Effect");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}