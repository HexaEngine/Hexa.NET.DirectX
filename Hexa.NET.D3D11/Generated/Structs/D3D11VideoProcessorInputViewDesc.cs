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
	[NativeName(NativeNameType.StructOrClass, "D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11VideoProcessorInputViewDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC::")]
		[StructLayout(LayoutKind.Explicit)]
		public partial struct D3D11VideoProcessorInputViewDescUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture2D")]
			[NativeName(NativeNameType.Type, "D3D11_TEX2D_VPIV")]
			[FieldOffset(0)]
			public D3D11Tex2DVpiv Texture2D;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe D3D11VideoProcessorInputViewDescUnion(D3D11Tex2DVpiv texture2D = default)
			{
				Texture2D = texture2D;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "FourCC")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint FourCC;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ViewDimension")]
		[NativeName(NativeNameType.Type, "D3D11_VPIV_DIMENSION")]
		public D3D11VpivDimension ViewDimension;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "")]
		[NativeName(NativeNameType.Type, "")]
		public D3D11VideoProcessorInputViewDescUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11VideoProcessorInputViewDesc(uint fourCc = default, D3D11VpivDimension viewDimension = default, D3D11VideoProcessorInputViewDescUnion union = default)
		{
			FourCC = fourCc;
			ViewDimension = viewDimension;
			Union = union;
		}


	}

}