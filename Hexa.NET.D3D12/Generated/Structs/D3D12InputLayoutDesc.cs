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
	[NativeName(NativeNameType.StructOrClass, "D3D12_INPUT_LAYOUT_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12InputLayoutDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pInputElementDescs")]
		[NativeName(NativeNameType.Type, "const D3D12_INPUT_ELEMENT_DESC*")]
		public unsafe D3D12InputElementDesc* PInputElementDescs;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NumElements")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NumElements;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12InputLayoutDesc(D3D12InputElementDesc* pInputElementDescs = default, uint numElements = default)
		{
			PInputElementDescs = pInputElementDescs;
			NumElements = numElements;
		}


	}

}