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
	public partial struct FeatureDataVideoDecodeFormatCount
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NodeIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoDecodeConfiguration Configuration;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint FormatCount;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe FeatureDataVideoDecodeFormatCount(uint nodeIndex = default, VideoDecodeConfiguration configuration = default, uint formatCount = default)
		{
			NodeIndex = nodeIndex;
			Configuration = configuration;
			FormatCount = formatCount;
		}


	}

}