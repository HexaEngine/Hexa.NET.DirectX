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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_DECODER_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoDecoderDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NodeMask")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NodeMask;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Configuration")]
		[NativeName(NativeNameType.Type, "D3D12_VIDEO_DECODE_CONFIGURATION")]
		public D3D12VideoDecodeConfiguration Configuration;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoDecoderDesc(uint nodeMask = default, D3D12VideoDecodeConfiguration configuration = default)
		{
			NodeMask = nodeMask;
			Configuration = configuration;
		}


	}

}