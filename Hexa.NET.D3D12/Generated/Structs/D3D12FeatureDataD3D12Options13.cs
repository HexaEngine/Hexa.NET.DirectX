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
	[NativeName(NativeNameType.StructOrClass, "D3D12_FEATURE_DATA_D3D12_OPTIONS13")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12FeatureDataD3D12Options13
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "UnrestrictedBufferTextureCopyPitchSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int UnrestrictedBufferTextureCopyPitchSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "UnrestrictedVertexElementAlignmentSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int UnrestrictedVertexElementAlignmentSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "InvertedViewportHeightFlipsYSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int InvertedViewportHeightFlipsYSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "InvertedViewportDepthFlipsZSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int InvertedViewportDepthFlipsZSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "TextureCopyBetweenDimensionsSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int TextureCopyBetweenDimensionsSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AlphaBlendFactorSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int AlphaBlendFactorSupported;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12FeatureDataD3D12Options13(int unrestrictedBufferTextureCopyPitchSupported = default, int unrestrictedVertexElementAlignmentSupported = default, int invertedViewportHeightFlipsYSupported = default, int invertedViewportDepthFlipsZSupported = default, int textureCopyBetweenDimensionsSupported = default, int alphaBlendFactorSupported = default)
		{
			UnrestrictedBufferTextureCopyPitchSupported = unrestrictedBufferTextureCopyPitchSupported;
			UnrestrictedVertexElementAlignmentSupported = unrestrictedVertexElementAlignmentSupported;
			InvertedViewportHeightFlipsYSupported = invertedViewportHeightFlipsYSupported;
			InvertedViewportDepthFlipsZSupported = invertedViewportDepthFlipsZSupported;
			TextureCopyBetweenDimensionsSupported = textureCopyBetweenDimensionsSupported;
			AlphaBlendFactorSupported = alphaBlendFactorSupported;
		}


	}

}