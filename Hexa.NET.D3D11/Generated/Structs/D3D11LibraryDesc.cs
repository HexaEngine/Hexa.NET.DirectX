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

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "_D3D11_LIBRARY_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11LibraryDesc
	{
		/// <summary>
		/// The name of the originator of the library.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Creator")]
		[NativeName(NativeNameType.Type, "LPCSTR")]
		public unsafe byte* Creator;

		/// <summary>
		/// Compilation flags.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Flags")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Flags;

		/// <summary>
		/// Number of functions exported from the library.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "FunctionCount")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint FunctionCount;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11LibraryDesc(byte* creator = default, uint flags = default, uint functionCount = default)
		{
			Creator = creator;
			Flags = flags;
			FunctionCount = functionCount;
		}


	}

}