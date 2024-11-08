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
	public partial struct FeatureDataD3D12Options6
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 AdditionalShadingRatesSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 PerPrimitiveShadingRateSupportedWithViewportIndexing;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VariableShadingRateTier VariableShadingRateTier;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ShadingRateImageTileSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 BackgroundProcessingSupported;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe FeatureDataD3D12Options6(Bool32 additionalShadingRatesSupported = default, Bool32 perPrimitiveShadingRateSupportedWithViewportIndexing = default, VariableShadingRateTier variableShadingRateTier = default, uint shadingRateImageTileSize = default, Bool32 backgroundProcessingSupported = default)
		{
			AdditionalShadingRatesSupported = additionalShadingRatesSupported;
			PerPrimitiveShadingRateSupportedWithViewportIndexing = perPrimitiveShadingRateSupportedWithViewportIndexing;
			VariableShadingRateTier = variableShadingRateTier;
			ShadingRateImageTileSize = shadingRateImageTileSize;
			BackgroundProcessingSupported = backgroundProcessingSupported;
		}


	}

}
