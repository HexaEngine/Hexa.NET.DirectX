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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_SCALE_SUPPORT")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoScaleSupport
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "OutputSizeRange")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_SIZE_RANGE")]
		public D3D12VideoSizeRange OutputSizeRange;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Flags")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_SCALE_SUPPORT_FLAGS")]
		public D3D12VideoScaleSupportFlags Flags;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoScaleSupport(D3D12VideoSizeRange outputSizeRange = default, D3D12VideoScaleSupportFlags flags = default)
		{
			OutputSizeRange = outputSizeRange;
			Flags = flags;
		}


	}

}