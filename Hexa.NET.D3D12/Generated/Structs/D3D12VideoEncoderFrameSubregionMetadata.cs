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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoEncoderFrameSubregionMetadata
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "bSize")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong BSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "bStartOffset")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong BStartOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "bHeaderSize")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong BHeaderSize;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoEncoderFrameSubregionMetadata(ulong bSize = default, ulong bStartOffset = default, ulong bHeaderSize = default)
		{
			BSize = bSize;
			BStartOffset = bStartOffset;
			BHeaderSize = bHeaderSize;
		}


	}

}