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
	[NativeName(NativeNameType.Enum, "D3D12_HIT_GROUP_TYPE")]
	[Flags]
	public enum D3D12HitGroupType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_HIT_GROUP_TYPE_TRIANGLES")]
		[NativeName(NativeNameType.Value, "0")]
		Triangles = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_HIT_GROUP_TYPE_PROCEDURAL_PRIMITIVE")]
		[NativeName(NativeNameType.Value, "1")]
		ProceduralPrimitive = unchecked(1),
	}
}