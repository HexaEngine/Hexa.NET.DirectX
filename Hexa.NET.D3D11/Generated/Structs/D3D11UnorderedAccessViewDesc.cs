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
	[NativeName(NativeNameType.StructOrClass, "D3D11_UNORDERED_ACCESS_VIEW_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11UnorderedAccessViewDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "D3D11_UNORDERED_ACCESS_VIEW_DESC::")]
		[StructLayout(LayoutKind.Explicit)]
		public partial struct D3D11UnorderedAccessViewDescUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Buffer")]
			[NativeName(NativeNameType.Type, "D3D11_BUFFER_UAV")]
			[FieldOffset(0)]
			public D3D11BufferUav Buffer;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture1D")]
			[NativeName(NativeNameType.Type, "D3D11_TEX1D_UAV")]
			[FieldOffset(0)]
			public D3D11Tex1DUav Texture1D;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture1DArray")]
			[NativeName(NativeNameType.Type, "D3D11_TEX1D_ARRAY_UAV")]
			[FieldOffset(0)]
			public D3D11Tex1DArrayUav Texture1DArray;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture2D")]
			[NativeName(NativeNameType.Type, "D3D11_TEX2D_UAV")]
			[FieldOffset(0)]
			public D3D11Tex2DUav Texture2D;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture2DArray")]
			[NativeName(NativeNameType.Type, "D3D11_TEX2D_ARRAY_UAV")]
			[FieldOffset(0)]
			public D3D11Tex2DArrayUav Texture2DArray;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Texture3D")]
			[NativeName(NativeNameType.Type, "D3D11_TEX3D_UAV")]
			[FieldOffset(0)]
			public D3D11Tex3DUav Texture3D;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe D3D11UnorderedAccessViewDescUnion(D3D11BufferUav buffer = default, D3D11Tex1DUav texture1D = default, D3D11Tex1DArrayUav texture1DArray = default, D3D11Tex2DUav texture2D = default, D3D11Tex2DArrayUav texture2DArray = default, D3D11Tex3DUav texture3D = default)
			{
				Buffer = buffer;
				Texture1D = texture1D;
				Texture1DArray = texture1DArray;
				Texture2D = texture2D;
				Texture2DArray = texture2DArray;
				Texture3D = texture3D;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Format")]
		[NativeName(NativeNameType.Type, "DXGI_FORMAT")]
		public DxgiFormat Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ViewDimension")]
		[NativeName(NativeNameType.Type, "D3D11_UAV_DIMENSION")]
		public D3D11UavDimension ViewDimension;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "")]
		[NativeName(NativeNameType.Type, "")]
		public D3D11UnorderedAccessViewDescUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11UnorderedAccessViewDesc(DxgiFormat format = default, D3D11UavDimension viewDimension = default, D3D11UnorderedAccessViewDescUnion union = default)
		{
			Format = format;
			ViewDimension = viewDimension;
			Union = union;
		}


	}

}