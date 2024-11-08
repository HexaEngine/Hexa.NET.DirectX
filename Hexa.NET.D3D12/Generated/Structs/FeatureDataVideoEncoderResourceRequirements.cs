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
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FeatureDataVideoEncoderResourceRequirements
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NodeIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderCodec Codec;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderProfileDesc Profile;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Format InputFormat;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderPictureResolutionDesc PictureTargetResolution;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 IsSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint CompressedBitstreamBufferAccessAlignment;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint EncoderMetadataBufferAccessAlignment;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MaxEncoderOutputMetadataBufferSize;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe FeatureDataVideoEncoderResourceRequirements(uint nodeIndex = default, VideoEncoderCodec codec = default, VideoEncoderProfileDesc profile = default, Format inputFormat = default, VideoEncoderPictureResolutionDesc pictureTargetResolution = default, Bool32 isSupported = default, uint compressedBitstreamBufferAccessAlignment = default, uint encoderMetadataBufferAccessAlignment = default, uint maxEncoderOutputMetadataBufferSize = default)
		{
			NodeIndex = nodeIndex;
			Codec = codec;
			Profile = profile;
			InputFormat = inputFormat;
			PictureTargetResolution = pictureTargetResolution;
			IsSupported = isSupported;
			CompressedBitstreamBufferAccessAlignment = compressedBitstreamBufferAccessAlignment;
			EncoderMetadataBufferAccessAlignment = encoderMetadataBufferAccessAlignment;
			MaxEncoderOutputMetadataBufferSize = maxEncoderOutputMetadataBufferSize;
		}


	}

}
