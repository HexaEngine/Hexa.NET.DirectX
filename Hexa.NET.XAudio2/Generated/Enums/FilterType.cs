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
using HexaGen.Runtime.COM;

namespace Hexa.NET.XAudio2
{
	/// <summary>
	/// Used in XAUDIO2_FILTER_PARAMETERS below<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "XAUDIO2_FILTER_TYPE")]
	[Flags]
	public enum FilterType : int
	{
		/// <summary>
		/// Attenuates frequencies above the cutoff frequency (state-variable filter).<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LowPassFilter")]
		[NativeName(NativeNameType.Value, "0")]
		LowPassFilter = unchecked(0),

		/// <summary>
		/// Attenuates frequencies outside a given range      (state-variable filter).<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BandPassFilter")]
		[NativeName(NativeNameType.Value, "1")]
		BandPassFilter = unchecked(1),

		/// <summary>
		/// Attenuates frequencies below the cutoff frequency (state-variable filter).<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "HighPassFilter")]
		[NativeName(NativeNameType.Value, "2")]
		HighPassFilter = unchecked(2),

		/// <summary>
		/// Attenuates frequencies inside a given range       (state-variable filter).<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "NotchFilter")]
		[NativeName(NativeNameType.Value, "3")]
		NotchFilter = unchecked(3),

		/// <summary>
		/// Attenuates frequencies above the cutoff frequency (one-pole filter, XAUDIO2_FILTER_PARAMETERS.OneOverQ has no effect)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "LowPassOnePoleFilter")]
		[NativeName(NativeNameType.Value, "4")]
		LowPassOnePoleFilter = unchecked(4),

		/// <summary>
		/// Attenuates frequencies below the cutoff frequency (one-pole filter, XAUDIO2_FILTER_PARAMETERS.OneOverQ has no effect)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "HighPassOnePoleFilter")]
		[NativeName(NativeNameType.Value, "5")]
		HighPassOnePoleFilter = unchecked(5),
	}
}
