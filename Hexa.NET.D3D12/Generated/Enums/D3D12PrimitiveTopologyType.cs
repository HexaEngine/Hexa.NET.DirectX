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
	[NativeName(NativeNameType.Enum, "D3D12_PRIMITIVE_TOPOLOGY_TYPE")]
	[Flags]
	public enum D3D12PrimitiveTopologyType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_PRIMITIVE_TOPOLOGY_TYPE_UNDEFINED")]
		[NativeName(NativeNameType.Value, "0")]
		Undefined = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_PRIMITIVE_TOPOLOGY_TYPE_POINT")]
		[NativeName(NativeNameType.Value, "1")]
		Point = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_PRIMITIVE_TOPOLOGY_TYPE_LINE")]
		[NativeName(NativeNameType.Value, "2")]
		Line = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE")]
		[NativeName(NativeNameType.Value, "3")]
		Triangle = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_PRIMITIVE_TOPOLOGY_TYPE_PATCH")]
		[NativeName(NativeNameType.Value, "4")]
		Patch = unchecked(4),
	}
}