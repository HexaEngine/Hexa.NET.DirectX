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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoEncoderCodecConfigurationSupportH264
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "SupportFlags")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS")]
		public D3D12VideoEncoderCodecConfigurationSupportH264Flags SupportFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DisableDeblockingFilterSupportedModes")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS")]
		public D3D12VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags DisableDeblockingFilterSupportedModes;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoEncoderCodecConfigurationSupportH264(D3D12VideoEncoderCodecConfigurationSupportH264Flags supportFlags = default, D3D12VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags disableDeblockingFilterSupportedModes = default)
		{
			SupportFlags = supportFlags;
			DisableDeblockingFilterSupportedModes = disableDeblockingFilterSupportedModes;
		}


	}

}