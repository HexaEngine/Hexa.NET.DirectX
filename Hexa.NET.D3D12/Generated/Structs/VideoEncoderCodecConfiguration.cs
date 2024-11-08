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
	public partial struct VideoEncoderCodecConfiguration
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		public partial struct VideoEncoderCodecConfigurationUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public unsafe VideoEncoderCodecConfigurationH264* PH264Config;

			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public unsafe VideoEncoderCodecConfigurationHevc* PHEVCConfig;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe VideoEncoderCodecConfigurationUnion(VideoEncoderCodecConfigurationH264* pH264Config = default, VideoEncoderCodecConfigurationHevc* pHEVCConfig = default)
			{
				PH264Config = pH264Config;
				PHEVCConfig = pHEVCConfig;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint DataSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderCodecConfigurationUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoEncoderCodecConfiguration(uint dataSize = default, VideoEncoderCodecConfigurationUnion union = default)
		{
			DataSize = dataSize;
			Union = union;
		}


	}

}
