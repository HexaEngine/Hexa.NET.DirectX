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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "DXGI_MODE_SCALING")]
	[Flags]
	public enum DxgiModeScaling : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_SCALING_UNSPECIFIED")]
		[NativeName(NativeNameType.Value, "0")]
		Unspecified = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_SCALING_CENTERED")]
		[NativeName(NativeNameType.Value, "1")]
		Centered = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_SCALING_STRETCHED")]
		[NativeName(NativeNameType.Value, "2")]
		Stretched = unchecked(2),
	}
}