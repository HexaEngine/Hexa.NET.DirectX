// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// interface __MIDL_itf_dxgi1_5_0000_0001 <br/>
	/// [local] <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "DXGI_HDR_METADATA_TYPE")]
	[Flags]
	public enum DxgiHdrMetadataType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_HDR_METADATA_TYPE_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_HDR_METADATA_TYPE_HDR10")]
		[NativeName(NativeNameType.Value, "1")]
		Hdr10 = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_HDR_METADATA_TYPE_HDR10PLUS")]
		[NativeName(NativeNameType.Value, "2")]
		Hdr10Plus = unchecked(2),
	}
}