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
	[NativeName(NativeNameType.Enum, "D3D12_RESOLVE_MODE")]
	[Flags]
	public enum D3D12ResolveMode : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RESOLVE_MODE_DECOMPRESS")]
		[NativeName(NativeNameType.Value, "0")]
		Decompress = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RESOLVE_MODE_MIN")]
		[NativeName(NativeNameType.Value, "1")]
		Min = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RESOLVE_MODE_MAX")]
		[NativeName(NativeNameType.Value, "2")]
		Max = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RESOLVE_MODE_AVERAGE")]
		[NativeName(NativeNameType.Value, "3")]
		Average = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK")]
		[NativeName(NativeNameType.Value, "4")]
		EncodeSamplerFeedback = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK")]
		[NativeName(NativeNameType.Value, "5")]
		DecodeSamplerFeedback = unchecked(5),
	}
}