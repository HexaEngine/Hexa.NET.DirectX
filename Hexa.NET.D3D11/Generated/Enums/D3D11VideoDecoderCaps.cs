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
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "D3D11_VIDEO_DECODER_CAPS")]
	[Flags]
	public enum D3D11VideoDecoderCaps : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE")]
		[NativeName(NativeNameType.Value, "1")]
		Downsample = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_DECODER_CAPS_NON_REAL_TIME")]
		[NativeName(NativeNameType.Value, "2")]
		NonRealTime = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_DYNAMIC")]
		[NativeName(NativeNameType.Value, "4")]
		DownsampleDynamic = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_DECODER_CAPS_DOWNSAMPLE_REQUIRED")]
		[NativeName(NativeNameType.Value, "8")]
		DownsampleRequired = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_DECODER_CAPS_UNSUPPORTED")]
		[NativeName(NativeNameType.Value, "16")]
		Unsupported = unchecked(16),
	}
}