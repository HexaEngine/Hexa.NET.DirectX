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
	[NativeName(NativeNameType.StructOrClass, "D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12FeatureDataVideoDecodeSupport
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NodeIndex")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NodeIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Configuration")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_DECODE_CONFIGURATION")]
		public D3D12VideoDecodeConfiguration Configuration;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Width")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Width;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Height")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Height;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DecodeFormat")]
		[NativeName(NativeNameType.Type, "DXGI_FORMAT")]
		public DxgiFormat DecodeFormat;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "FrameRate")]
		[NativeName(NativeNameType.Type, "DXGI_RATIONAL")]
		public DxgiRational FrameRate;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "BitRate")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint BitRate;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "SupportFlags")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_DECODE_SUPPORT_FLAGS")]
		public D3D12VideoDecodeSupportFlags SupportFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ConfigurationFlags")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS")]
		public D3D12VideoDecodeConfigurationFlags ConfigurationFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DecodeTier")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_DECODE_TIER")]
		public D3D12VideoDecodeTier DecodeTier;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12FeatureDataVideoDecodeSupport(uint nodeIndex = default, D3D12VideoDecodeConfiguration configuration = default, uint width = default, uint height = default, DxgiFormat decodeFormat = default, DxgiRational frameRate = default, uint bitRate = default, D3D12VideoDecodeSupportFlags supportFlags = default, D3D12VideoDecodeConfigurationFlags configurationFlags = default, D3D12VideoDecodeTier decodeTier = default)
		{
			NodeIndex = nodeIndex;
			Configuration = configuration;
			Width = width;
			Height = height;
			DecodeFormat = decodeFormat;
			FrameRate = frameRate;
			BitRate = bitRate;
			SupportFlags = supportFlags;
			ConfigurationFlags = configurationFlags;
			DecodeTier = decodeTier;
		}


	}

}