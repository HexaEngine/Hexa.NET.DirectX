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
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoSampleDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Width;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Height;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Format Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ColorSpaceType ColorSpace;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoSampleDesc(uint width = default, uint height = default, Format format = default, ColorSpaceType colorSpace = default)
		{
			Width = width;
			Height = height;
			Format = format;
			ColorSpace = colorSpace;
		}


	}

}