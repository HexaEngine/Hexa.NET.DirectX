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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoEncoderLevelTierConstraintsHevc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Level")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_ENCODER_LEVELS_HEVC")]
		public D3D12VideoEncoderLevelsHevc Level;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Tier")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_ENCODER_TIER_HEVC")]
		public D3D12VideoEncoderTierHevc Tier;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoEncoderLevelTierConstraintsHevc(D3D12VideoEncoderLevelsHevc level = default, D3D12VideoEncoderTierHevc tier = default)
		{
			Level = level;
			Tier = tier;
		}


	}

}