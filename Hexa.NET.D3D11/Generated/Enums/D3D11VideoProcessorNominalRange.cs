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
	[NativeName(NativeNameType.Enum, "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE")]
	[Flags]
	public enum D3D11VideoProcessorNominalRange : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED")]
		[NativeName(NativeNameType.Value, "0")]
		Undefined = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235")]
		[NativeName(NativeNameType.Value, "1")]
		Range16235 = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255")]
		[NativeName(NativeNameType.Value, "2")]
		Range0255 = unchecked(2),
	}
}