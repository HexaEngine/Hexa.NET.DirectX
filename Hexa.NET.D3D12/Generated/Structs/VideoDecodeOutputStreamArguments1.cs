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
	public partial struct VideoDecodeOutputStreamArguments1
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ID3D12Resource* POutputTexture2D;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint OutputSubresource;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoDecodeConversionArguments1 ConversionArguments;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoDecodeOutputHistogram Histograms_0;
		public VideoDecodeOutputHistogram Histograms_1;
		public VideoDecodeOutputHistogram Histograms_2;
		public VideoDecodeOutputHistogram Histograms_3;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoDecodeOutputStreamArguments1(ID3D12Resource* pOutputTexture2D = default, uint outputSubresource = default, VideoDecodeConversionArguments1 conversionArguments = default, VideoDecodeOutputHistogram* histograms = default)
		{
			POutputTexture2D = pOutputTexture2D;
			OutputSubresource = outputSubresource;
			ConversionArguments = conversionArguments;
			if (histograms != default(VideoDecodeOutputHistogram*))
			{
				Histograms_0 = histograms[0];
				Histograms_1 = histograms[1];
				Histograms_2 = histograms[2];
				Histograms_3 = histograms[3];
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoDecodeOutputStreamArguments1(ID3D12Resource* pOutputTexture2D = default, uint outputSubresource = default, VideoDecodeConversionArguments1 conversionArguments = default, Span<VideoDecodeOutputHistogram> histograms = default)
		{
			POutputTexture2D = pOutputTexture2D;
			OutputSubresource = outputSubresource;
			ConversionArguments = conversionArguments;
			if (histograms != default(Span<VideoDecodeOutputHistogram>))
			{
				Histograms_0 = histograms[0];
				Histograms_1 = histograms[1];
				Histograms_2 = histograms[2];
				Histograms_3 = histograms[3];
			}
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<VideoDecodeOutputHistogram> Histograms
		
		{
			get
			{
				fixed (VideoDecodeOutputHistogram* p = &this.Histograms_0)
				{
					return new Span<VideoDecodeOutputHistogram>(p, 4);
				}
			}
		}
	}

}
