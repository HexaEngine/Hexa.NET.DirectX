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

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "D3D11_FEATURE_DATA_D3D9_OPTIONS1")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11FeatureDataD3D9Options1
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "FullNonPow2TextureSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int FullNonPow2TextureSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DepthAsTextureWithLessEqualComparisonFilterSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int DepthAsTextureWithLessEqualComparisonFilterSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "SimpleInstancingSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int SimpleInstancingSupported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11FeatureDataD3D9Options1(int fullNonPow2TextureSupported = default, int depthAsTextureWithLessEqualComparisonFilterSupported = default, int simpleInstancingSupported = default, int textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = default)
		{
			FullNonPow2TextureSupported = fullNonPow2TextureSupported;
			DepthAsTextureWithLessEqualComparisonFilterSupported = depthAsTextureWithLessEqualComparisonFilterSupported;
			SimpleInstancingSupported = simpleInstancingSupported;
			TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported = textureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
		}


	}

}