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

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "D3D11_COUNTER_TYPE")]
	[Flags]
	public enum D3D11CounterType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_COUNTER_TYPE_FLOAT32")]
		[NativeName(NativeNameType.Value, "0")]
		Float32 = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_COUNTER_TYPE_UINT16")]
		[NativeName(NativeNameType.Value, "1")]
		Uint16 = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_COUNTER_TYPE_UINT32")]
		[NativeName(NativeNameType.Value, "2")]
		Uint32 = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_COUNTER_TYPE_UINT64")]
		[NativeName(NativeNameType.Value, "3")]
		Uint64 = unchecked(3),
	}
}