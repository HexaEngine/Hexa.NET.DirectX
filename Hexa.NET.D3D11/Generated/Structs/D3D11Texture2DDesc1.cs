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
	[NativeName(NativeNameType.StructOrClass, "D3D11_TEXTURE2D_DESC1")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11Texture2DDesc1
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
		[NativeName(NativeNameType.Field, "MipLevels")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint MipLevels;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ArraySize")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint ArraySize;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Format")]
		[NativeName(NativeNameType.Type, "DXGI_FORMAT")]
		public DxgiFormat Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "SampleDesc")]
		[NativeName(NativeNameType.Type, "DXGI_SAMPLE_DESC")]
		public DxgiSampleDesc SampleDesc;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Usage")]
		[NativeName(NativeNameType.Type, "D3D11_USAGE")]
		public D3D11Usage Usage;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "BindFlags")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint BindFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "CPUAccessFlags")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint CPUAccessFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "MiscFlags")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint MiscFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "TextureLayout")]
		[NativeName(NativeNameType.Type, "D3D11_TEXTURE_LAYOUT")]
		public D3D11TextureLayout TextureLayout;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11Texture2DDesc1(uint width = default, uint height = default, uint mipLevels = default, uint arraySize = default, DxgiFormat format = default, DxgiSampleDesc sampleDesc = default, D3D11Usage usage = default, uint bindFlags = default, uint cpuAccessFlags = default, uint miscFlags = default, D3D11TextureLayout textureLayout = default)
		{
			Width = width;
			Height = height;
			MipLevels = mipLevels;
			ArraySize = arraySize;
			Format = format;
			SampleDesc = sampleDesc;
			Usage = usage;
			BindFlags = bindFlags;
			CPUAccessFlags = cpuAccessFlags;
			MiscFlags = miscFlags;
			TextureLayout = textureLayout;
		}


	}

}