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
	public partial struct VideoEncoderPictureControlDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint IntraRefreshFrameIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderPictureControlFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderPictureControlCodecData PictureControlCodecData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncodeReferenceFrames ReferenceFrames;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoEncoderPictureControlDesc(uint intraRefreshFrameIndex = default, VideoEncoderPictureControlFlags flags = default, VideoEncoderPictureControlCodecData pictureControlCodecData = default, VideoEncodeReferenceFrames referenceFrames = default)
		{
			IntraRefreshFrameIndex = intraRefreshFrameIndex;
			Flags = flags;
			PictureControlCodecData = pictureControlCodecData;
			ReferenceFrames = referenceFrames;
		}


	}

}
