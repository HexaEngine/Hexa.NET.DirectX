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
	public partial struct VideoEncoderEncodeframeInputArguments
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderSequenceControlDesc SequenceControlDesc;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderPictureControlDesc PictureControlDesc;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ID3D12Resource* PInputFrame;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InputFrameSubresource;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint CurrentFrameBitstreamMetadataSize;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoEncoderEncodeframeInputArguments(VideoEncoderSequenceControlDesc sequenceControlDesc = default, VideoEncoderPictureControlDesc pictureControlDesc = default, ID3D12Resource* pInputFrame = default, uint inputFrameSubresource = default, uint currentFrameBitstreamMetadataSize = default)
		{
			SequenceControlDesc = sequenceControlDesc;
			PictureControlDesc = pictureControlDesc;
			PInputFrame = pInputFrame;
			InputFrameSubresource = inputFrameSubresource;
			CurrentFrameBitstreamMetadataSize = currentFrameBitstreamMetadataSize;
		}


	}

}