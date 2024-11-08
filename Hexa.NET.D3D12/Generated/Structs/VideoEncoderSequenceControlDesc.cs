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
	public partial struct VideoEncoderSequenceControlDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderSequenceControlFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderIntraRefresh IntraRefreshConfig;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderRateControl RateControl;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderPictureResolutionDesc PictureTargetResolution;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderFrameSubregionLayoutMode SelectedLayoutMode;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderPictureControlSubregionsLayoutData FrameSubregionsLayoutData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderSequenceGopStructure CodecGopSequence;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoEncoderSequenceControlDesc(VideoEncoderSequenceControlFlags flags = default, VideoEncoderIntraRefresh intraRefreshConfig = default, VideoEncoderRateControl rateControl = default, VideoEncoderPictureResolutionDesc pictureTargetResolution = default, VideoEncoderFrameSubregionLayoutMode selectedLayoutMode = default, VideoEncoderPictureControlSubregionsLayoutData frameSubregionsLayoutData = default, VideoEncoderSequenceGopStructure codecGopSequence = default)
		{
			Flags = flags;
			IntraRefreshConfig = intraRefreshConfig;
			RateControl = rateControl;
			PictureTargetResolution = pictureTargetResolution;
			SelectedLayoutMode = selectedLayoutMode;
			FrameSubregionsLayoutData = frameSubregionsLayoutData;
			CodecGopSequence = codecGopSequence;
		}


	}

}
