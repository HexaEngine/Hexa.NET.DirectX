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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoEncoderCodecConfiguration
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION::")]
		[StructLayout(LayoutKind.Explicit)]
		public partial struct D3D12VideoEncoderCodecConfigurationUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "pH264Config")]
			[NativeName(NativeNameType.Type, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264*")]
			[FieldOffset(0)]
			public unsafe D3D12VideoEncoderCodecConfigurationH264* PH264Config;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "pHEVCConfig")]
			[NativeName(NativeNameType.Type, "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC*")]
			[FieldOffset(0)]
			public unsafe D3D12VideoEncoderCodecConfigurationHevc* PHEVCConfig;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe D3D12VideoEncoderCodecConfigurationUnion(D3D12VideoEncoderCodecConfigurationH264* pH264Config = default, D3D12VideoEncoderCodecConfigurationHevc* pHEVCConfig = default)
			{
				PH264Config = pH264Config;
				PHEVCConfig = pHEVCConfig;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DataSize")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint DataSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "")]
		[NativeName(NativeNameType.Type, "")]
		public D3D12VideoEncoderCodecConfigurationUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoEncoderCodecConfiguration(uint dataSize = default, D3D12VideoEncoderCodecConfigurationUnion union = default)
		{
			DataSize = dataSize;
			Union = union;
		}


	}

}