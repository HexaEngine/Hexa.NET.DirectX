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
	[NativeName(NativeNameType.StructOrClass, "D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12FeatureDataVideoMotionEstimator
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NodeIndex")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NodeIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "InputFormat")]
		[NativeName(NativeNameType.Type, "DXGI_FORMAT")]
		public DxgiFormat InputFormat;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "BlockSizeFlags")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS")]
		public D3D12VideoMotionEstimatorSearchBlockSizeFlags BlockSizeFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "PrecisionFlags")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS")]
		public D3D12VideoMotionEstimatorVectorPrecisionFlags PrecisionFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "SizeRange")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_SIZE_RANGE")]
		public D3D12VideoSizeRange SizeRange;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12FeatureDataVideoMotionEstimator(uint nodeIndex = default, DxgiFormat inputFormat = default, D3D12VideoMotionEstimatorSearchBlockSizeFlags blockSizeFlags = default, D3D12VideoMotionEstimatorVectorPrecisionFlags precisionFlags = default, D3D12VideoSizeRange sizeRange = default)
		{
			NodeIndex = nodeIndex;
			InputFormat = inputFormat;
			BlockSizeFlags = blockSizeFlags;
			PrecisionFlags = precisionFlags;
			SizeRange = sizeRange;
		}


	}

}