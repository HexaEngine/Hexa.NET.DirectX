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
	public partial struct VideoEncoderLevelSetting
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		public partial struct VideoEncoderLevelSettingUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public unsafe VideoEncoderLevelsH264* PH264LevelSetting;

			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public unsafe VideoEncoderLevelTierConstraintsHevc* PHEVCLevelSetting;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe VideoEncoderLevelSettingUnion(VideoEncoderLevelsH264* pH264LevelSetting = default, VideoEncoderLevelTierConstraintsHevc* pHEVCLevelSetting = default)
			{
				PH264LevelSetting = pH264LevelSetting;
				PHEVCLevelSetting = pHEVCLevelSetting;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint DataSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoEncoderLevelSettingUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoEncoderLevelSetting(uint dataSize = default, VideoEncoderLevelSettingUnion union = default)
		{
			DataSize = dataSize;
			Union = union;
		}


	}

}