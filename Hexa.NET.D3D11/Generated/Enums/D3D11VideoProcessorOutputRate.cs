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
	[NativeName(NativeNameType.Enum, "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE")]
	[Flags]
	public enum D3D11VideoProcessorOutputRate : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_NORMAL")]
		[NativeName(NativeNameType.Value, "0")]
		Normal = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_HALF")]
		[NativeName(NativeNameType.Value, "1")]
		Half = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_CUSTOM")]
		[NativeName(NativeNameType.Value, "2")]
		Custom = unchecked(2),
	}
}