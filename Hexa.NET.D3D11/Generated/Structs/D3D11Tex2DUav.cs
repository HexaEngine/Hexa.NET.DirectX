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
	[NativeName(NativeNameType.StructOrClass, "D3D11_TEX2D_UAV")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11Tex2DUav
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "MipSlice")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint MipSlice;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11Tex2DUav(uint mipSlice = default)
		{
			MipSlice = mipSlice;
		}


	}

}