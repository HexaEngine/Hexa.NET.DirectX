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
	[NativeName(NativeNameType.StructOrClass, "D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11VideoDecoderOutputViewDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC::")]
		[StructLayout(LayoutKind.Explicit)]
		public partial struct D3D11VideoDecoderOutputViewDescUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture2D")]
			[NativeName(NativeNameType.Type, "D3D11_TEX2D_VDOV")]
			[FieldOffset(0)]
			public D3D11Tex2DVdov Texture2D;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe D3D11VideoDecoderOutputViewDescUnion(D3D11Tex2DVdov texture2D = default)
			{
				Texture2D = texture2D;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DecodeProfile")]
		[NativeName(NativeNameType.Type, "GUID")]
		public Guid DecodeProfile;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ViewDimension")]
		[NativeName(NativeNameType.Type, "D3D11_VDOV_DIMENSION")]
		public D3D11VdovDimension ViewDimension;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "")]
		[NativeName(NativeNameType.Type, "")]
		public D3D11VideoDecoderOutputViewDescUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11VideoDecoderOutputViewDesc(Guid decodeProfile = default, D3D11VdovDimension viewDimension = default, D3D11VideoDecoderOutputViewDescUnion union = default)
		{
			DecodeProfile = decodeProfile;
			ViewDimension = viewDimension;
			Union = union;
		}


	}

}