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
	[NativeName(NativeNameType.Enum, "D3D12_ELEMENTS_LAYOUT")]
	[Flags]
	public enum D3D12ElementsLayout : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_ELEMENTS_LAYOUT_ARRAY")]
		[NativeName(NativeNameType.Value, "0")]
		Array = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS")]
		[NativeName(NativeNameType.Value, "1")]
		ArrayOfPointers = unchecked(1),
	}
}