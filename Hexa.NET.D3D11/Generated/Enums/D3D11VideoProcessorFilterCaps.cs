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
	[NativeName(NativeNameType.Enum, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS")]
	[Flags]
	public enum D3D11VideoProcessorFilterCaps : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS")]
		[NativeName(NativeNameType.Value, "1")]
		Brightness = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST")]
		[NativeName(NativeNameType.Value, "2")]
		Contrast = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE")]
		[NativeName(NativeNameType.Value, "4")]
		Hue = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION")]
		[NativeName(NativeNameType.Value, "8")]
		Saturation = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION")]
		[NativeName(NativeNameType.Value, "16")]
		NoiseReduction = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT")]
		[NativeName(NativeNameType.Value, "32")]
		EdgeEnhancement = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING")]
		[NativeName(NativeNameType.Value, "64")]
		AnamorphicScaling = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT")]
		[NativeName(NativeNameType.Value, "128")]
		StereoAdjustment = unchecked(128),
	}
}