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
	[NativeName(NativeNameType.Enum, "DXGI_MODE_ROTATION")]
	[Flags]
	public enum DxgiModeRotation : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_ROTATION_UNSPECIFIED")]
		[NativeName(NativeNameType.Value, "0")]
		Unspecified = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_ROTATION_IDENTITY")]
		[NativeName(NativeNameType.Value, "1")]
		Identity = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_ROTATION_ROTATE90")]
		[NativeName(NativeNameType.Value, "2")]
		Rotate90 = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_ROTATION_ROTATE180")]
		[NativeName(NativeNameType.Value, "3")]
		Rotate180 = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_MODE_ROTATION_ROTATE270")]
		[NativeName(NativeNameType.Value, "4")]
		Rotate270 = unchecked(4),
	}
}