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
	[Flags]
	public enum VideoProcessFilterFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		FlagNone = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagBrightness = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagContrast = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagHue = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagSaturation = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagNoiseReduction = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagEdgeEnhancement = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAnamorphicScaling = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagStereoAdjustment = unchecked(128),
	}
}