// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
	[Flags]
	public enum D3D12IndexBufferStripCutValue : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED")]
		[NativeName(NativeNameType.Value, "0")]
		Disabled = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF")]
		[NativeName(NativeNameType.Value, "1")]
		Value0XFfff = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF")]
		[NativeName(NativeNameType.Value, "2")]
		Value0XFfffffff = unchecked(2),
	}
}