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
	[NativeName(NativeNameType.Enum, "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS")]
	[Flags]
	public enum D3D12VideoProcessInputStreamFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		FlagNone = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY")]
		[NativeName(NativeNameType.Value, "1")]
		FlagFrameDiscontinuity = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT")]
		[NativeName(NativeNameType.Value, "2")]
		FlagFrameRepeat = unchecked(2),
	}
}