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
	public partial struct Texture2DDesc1
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
		public uint MipLevels;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ArraySize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Format Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		public SampleDesc SampleDesc;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Usage Usage;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BindFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint CPUAccessFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MiscFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public TextureLayout TextureLayout;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Texture2DDesc1(uint width = default, uint height = default, uint mipLevels = default, uint arraySize = default, Format format = default, SampleDesc sampleDesc = default, Usage usage = default, uint bindFlags = default, uint cpuAccessFlags = default, uint miscFlags = default, TextureLayout textureLayout = default)
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