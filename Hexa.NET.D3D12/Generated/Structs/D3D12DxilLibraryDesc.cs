// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "D3D12_DXIL_LIBRARY_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12DxilLibraryDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DXILLibrary")]
		[NativeName(NativeNameType.Type, "D3D12_SHADER_BYTECODE")]
		public D3D12ShaderBytecode DXILLibrary;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NumExports")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NumExports;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pExports")]
		[NativeName(NativeNameType.Type, "D3D12_EXPORT_DESC*")]
		public unsafe D3D12ExportDesc* PExports;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12DxilLibraryDesc(D3D12ShaderBytecode dxilLibrary = default, uint numExports = default, D3D12ExportDesc* pExports = default)
		{
			DXILLibrary = dxilLibrary;
			NumExports = numExports;
			PExports = pExports;
		}


	}

}