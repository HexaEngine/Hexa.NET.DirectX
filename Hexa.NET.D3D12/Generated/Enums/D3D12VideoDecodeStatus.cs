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

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "D3D12_VIDEO_DECODE_STATUS")]
	[Flags]
	public enum D3D12VideoDecodeStatus : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_DECODE_STATUS_OK")]
		[NativeName(NativeNameType.Value, "0")]
		Ok = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_DECODE_STATUS_CONTINUE")]
		[NativeName(NativeNameType.Value, "1")]
		Continue = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY")]
		[NativeName(NativeNameType.Value, "2")]
		ContinueSkipDisplay = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_DECODE_STATUS_RESTART")]
		[NativeName(NativeNameType.Value, "3")]
		Restart = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED")]
		[NativeName(NativeNameType.Value, "4")]
		RateExceeded = unchecked(4),
	}
}