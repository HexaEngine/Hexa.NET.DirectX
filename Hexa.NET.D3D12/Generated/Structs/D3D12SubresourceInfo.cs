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
	[NativeName(NativeNameType.StructOrClass, "D3D12_SUBRESOURCE_INFO")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12SubresourceInfo
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Offset")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong Offset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "RowPitch")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint RowPitch;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DepthPitch")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint DepthPitch;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12SubresourceInfo(ulong offset = default, uint rowPitch = default, uint depthPitch = default)
		{
			Offset = offset;
			RowPitch = rowPitch;
			DepthPitch = depthPitch;
		}


	}

}