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
	[NativeName(NativeNameType.StructOrClass, "D3D11_VIDEO_SAMPLE_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11VideoSampleDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Width")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Width;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Height")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Height;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Format")]
		[NativeName(NativeNameType.Type, "DXGI_FORMAT")]
		public DxgiFormat Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ColorSpace")]
		[NativeName(NativeNameType.Type, "DXGI_COLOR_SPACE_TYPE")]
		public DxgiColorSpaceType ColorSpace;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11VideoSampleDesc(uint width = default, uint height = default, DxgiFormat format = default, DxgiColorSpaceType colorSpace = default)
		{
			Width = width;
			Height = height;
			Format = format;
			ColorSpace = colorSpace;
		}


	}

}