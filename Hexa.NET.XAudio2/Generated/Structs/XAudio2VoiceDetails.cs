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
	/// Returned by IXAudio2Voice::GetVoiceDetails<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "XAUDIO2_VOICE_DETAILS")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct XAudio2VoiceDetails
	{
		/// <summary>
		/// Flags the voice was created with.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "CreationFlags")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint CreationFlags;

		/// <summary>
		/// Flags currently active.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveFlags")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveFlags;

		/// <summary>
		/// Channels in the voice's input audio.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "InputChannels")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint InputChannels;

		/// <summary>
		/// Sample rate of the voice's input audio.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "InputSampleRate")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint InputSampleRate;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe XAudio2VoiceDetails(uint creationFlags = default, uint activeFlags = default, uint inputChannels = default, uint inputSampleRate = default)
		{
			CreationFlags = creationFlags;
			ActiveFlags = activeFlags;
			InputChannels = inputChannels;
			InputSampleRate = inputSampleRate;
		}


	}

}