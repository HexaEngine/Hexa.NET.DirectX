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
	[NativeName(NativeNameType.Enum, "D3D12_FEATURE_VIDEO")]
	[Flags]
	public enum D3D12FeatureVideo : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_SUPPORT")]
		[NativeName(NativeNameType.Value, "0")]
		DecodeSupport = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_PROFILES")]
		[NativeName(NativeNameType.Value, "1")]
		DecodeProfiles = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_FORMATS")]
		[NativeName(NativeNameType.Value, "2")]
		DecodeFormats = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT")]
		[NativeName(NativeNameType.Value, "3")]
		DecodeConversionSupport = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_PROCESS_SUPPORT")]
		[NativeName(NativeNameType.Value, "5")]
		ProcessSupport = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS")]
		[NativeName(NativeNameType.Value, "6")]
		ProcessMaxInputStreams = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO")]
		[NativeName(NativeNameType.Value, "7")]
		ProcessReferenceInfo = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE")]
		[NativeName(NativeNameType.Value, "8")]
		DecoderHeapSize = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE")]
		[NativeName(NativeNameType.Value, "9")]
		ProcessorSize = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT")]
		[NativeName(NativeNameType.Value, "10")]
		DecodeProfileCount = unchecked(10),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT")]
		[NativeName(NativeNameType.Value, "11")]
		DecodeFormatCount = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ARCHITECTURE")]
		[NativeName(NativeNameType.Value, "17")]
		Architecture = unchecked(17),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM")]
		[NativeName(NativeNameType.Value, "18")]
		DecodeHistogram = unchecked(18),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT")]
		[NativeName(NativeNameType.Value, "19")]
		AreaSupport = unchecked(19),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR")]
		[NativeName(NativeNameType.Value, "20")]
		MotionEstimator = unchecked(20),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE")]
		[NativeName(NativeNameType.Value, "21")]
		MotionEstimatorSize = unchecked(21),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_COUNT")]
		[NativeName(NativeNameType.Value, "22")]
		ExtensionCommandCount = unchecked(22),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_EXTENSION_COMMANDS")]
		[NativeName(NativeNameType.Value, "23")]
		ExtensionCommands = unchecked(23),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT")]
		[NativeName(NativeNameType.Value, "24")]
		ExtensionCommandParameterCount = unchecked(24),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETERS")]
		[NativeName(NativeNameType.Value, "25")]
		ExtensionCommandParameters = unchecked(25),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SUPPORT")]
		[NativeName(NativeNameType.Value, "26")]
		ExtensionCommandSupport = unchecked(26),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SIZE")]
		[NativeName(NativeNameType.Value, "27")]
		ExtensionCommandSize = unchecked(27),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODE_PROTECTED_RESOURCES")]
		[NativeName(NativeNameType.Value, "28")]
		DecodeProtectedResources = unchecked(28),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_PROCESS_PROTECTED_RESOURCES")]
		[NativeName(NativeNameType.Value, "29")]
		ProcessProtectedResources = unchecked(29),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES")]
		[NativeName(NativeNameType.Value, "30")]
		MotionEstimatorProtectedResources = unchecked(30),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE1")]
		[NativeName(NativeNameType.Value, "31")]
		DecoderHeapSize1 = unchecked(31),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_PROCESSOR_SIZE1")]
		[NativeName(NativeNameType.Value, "32")]
		ProcessorSize1 = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_CODEC")]
		[NativeName(NativeNameType.Value, "33")]
		EncoderCodec = unchecked(33),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_PROFILE_LEVEL")]
		[NativeName(NativeNameType.Value, "34")]
		EncoderProfileLevel = unchecked(34),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT")]
		[NativeName(NativeNameType.Value, "35")]
		EncoderOutputResolutionRatiosCount = unchecked(35),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION")]
		[NativeName(NativeNameType.Value, "36")]
		EncoderOutputResolution = unchecked(36),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_INPUT_FORMAT")]
		[NativeName(NativeNameType.Value, "37")]
		EncoderInputFormat = unchecked(37),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_RATE_CONTROL_MODE")]
		[NativeName(NativeNameType.Value, "38")]
		EncoderRateControlMode = unchecked(38),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
		[NativeName(NativeNameType.Value, "39")]
		EncoderIntraRefreshMode = unchecked(39),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
		[NativeName(NativeNameType.Value, "40")]
		EncoderFrameSubregionLayoutMode = unchecked(40),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_HEAP_SIZE")]
		[NativeName(NativeNameType.Value, "41")]
		EncoderHeapSize = unchecked(41),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT")]
		[NativeName(NativeNameType.Value, "42")]
		EncoderCodecConfigurationSupport = unchecked(42),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_SUPPORT")]
		[NativeName(NativeNameType.Value, "43")]
		EncoderSupport = unchecked(43),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT")]
		[NativeName(NativeNameType.Value, "44")]
		EncoderCodecPictureControlSupport = unchecked(44),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_FEATURE_VIDEO_ENCODER_RESOURCE_REQUIREMENTS")]
		[NativeName(NativeNameType.Value, "45")]
		EncoderResourceRequirements = unchecked(45),
	}
}