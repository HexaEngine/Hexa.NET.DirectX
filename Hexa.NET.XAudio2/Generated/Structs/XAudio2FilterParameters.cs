// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using HexaGen.Runtime.COM;

namespace Hexa.NET.XAudio2
{
	/// <summary>
	/// Used in IXAudio2Voice::Set/GetFilterParameters and Set/GetOutputFilterParameters<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "XAUDIO2_FILTER_PARAMETERS")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct XAudio2FilterParameters
	{
		/// <summary>
		/// Filter type.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Type")]
		[NativeName(NativeNameType.Type, "XAUDIO2_FILTER_TYPE")]
		public FilterType Type;

		/// <summary>
		/// Filter coefficient.<br/>
		/// must be >= 0 and <br/>
		/// <<br/>
		/// = XAUDIO2_MAX_FILTER_FREQUENCY<br/>
		/// See XAudio2CutoffFrequencyToRadians() for state-variable filter types and<br/>
		/// XAudio2CutoffFrequencyToOnePoleCoefficient() for one-pole filter types.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Frequency")]
		[NativeName(NativeNameType.Type, "float")]
		public float Frequency;

		/// <summary>
		/// Reciprocal of the filter's quality factor Q;<br/>
		/// must be > 0 and <br/>
		/// <<br/>
		/// = XAUDIO2_MAX_FILTER_ONEOVERQ.<br/>
		/// Has no effect for one-pole filters.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "OneOverQ")]
		[NativeName(NativeNameType.Type, "float")]
		public float OneOverQ;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe XAudio2FilterParameters(FilterType type = default, float frequency = default, float oneOverQ = default)
		{
			Type = type;
			Frequency = frequency;
			OneOverQ = oneOverQ;
		}


	}

}
