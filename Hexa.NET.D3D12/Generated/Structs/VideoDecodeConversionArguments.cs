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
	public partial struct VideoDecodeConversionArguments
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public int Enable;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ID3D12Resource* PReferenceTexture2D;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ReferenceSubresource;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ColorSpaceType OutputColorSpace;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ColorSpaceType DecodeColorSpace;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoDecodeConversionArguments(int enable = default, ID3D12Resource* pReferenceTexture2D = default, uint referenceSubresource = default, ColorSpaceType outputColorSpace = default, ColorSpaceType decodeColorSpace = default)
		{
			Enable = enable;
			PReferenceTexture2D = pReferenceTexture2D;
			ReferenceSubresource = referenceSubresource;
			OutputColorSpace = outputColorSpace;
			DecodeColorSpace = decodeColorSpace;
		}


	}

}