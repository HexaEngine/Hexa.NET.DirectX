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
	/// interface __MIDL_itf_dxgi1_3_0000_0007 <br/>
	/// [local] <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "DXGI_OVERLAY_SUPPORT_FLAG")]
	[Flags]
	public enum DxgiOverlaySupportFlag : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_OVERLAY_SUPPORT_FLAG_DIRECT")]
		[NativeName(NativeNameType.Value, "1")]
		Direct = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_OVERLAY_SUPPORT_FLAG_SCALING")]
		[NativeName(NativeNameType.Value, "2")]
		Scaling = unchecked(2),
	}
}