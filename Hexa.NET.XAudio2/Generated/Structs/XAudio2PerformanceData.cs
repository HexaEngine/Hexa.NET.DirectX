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
	/// Returned by IXAudio2::GetPerformanceData<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "XAUDIO2_PERFORMANCE_DATA")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct XAudio2PerformanceData
	{
		/// <summary>
		/// CPU cycles spent on audio processing since the<br/>
		/// last call to StartEngine or GetPerformanceData.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "AudioCyclesSinceLastQuery")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong AudioCyclesSinceLastQuery;

		/// <summary>
		/// Total CPU cycles elapsed since the last call<br/>
		/// (only counts the CPU XAudio2 is running on).<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "TotalCyclesSinceLastQuery")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong TotalCyclesSinceLastQuery;

		/// <summary>
		/// Fewest CPU cycles spent processing any one<br/>
		/// audio quantum since the last call.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "MinimumCyclesPerQuantum")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint MinimumCyclesPerQuantum;

		/// <summary>
		/// Most CPU cycles spent processing any one<br/>
		/// audio quantum since the last call.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "MaximumCyclesPerQuantum")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint MaximumCyclesPerQuantum;

		/// <summary>
		/// Total heap space currently in use.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "MemoryUsageInBytes")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint MemoryUsageInBytes;

		/// <summary>
		/// Minimum delay from when a sample is read from a<br/>
		/// source buffer to when it reaches the speakers.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "CurrentLatencyInSamples")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint CurrentLatencyInSamples;

		/// <summary>
		/// Audio dropouts since the engine was started.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "GlitchesSinceEngineStarted")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint GlitchesSinceEngineStarted;

		/// <summary>
		/// Source voices currently playing.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveSourceVoiceCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveSourceVoiceCount;

		/// <summary>
		/// Source voices currently existing.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "TotalSourceVoiceCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint TotalSourceVoiceCount;

		/// <summary>
		/// Submix voices currently playing/existing.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveSubmixVoiceCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveSubmixVoiceCount;

		/// <summary>
		/// Resample xAPOs currently active.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveResamplerCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveResamplerCount;

		/// <summary>
		/// MatrixMix xAPOs currently active.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveMatrixMixCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveMatrixMixCount;

		/// <summary>
		/// Number of source voices decoding XMA data.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveXmaSourceVoices")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveXmaSourceVoices;

		/// <summary>
		/// A voice can use more than one XMA stream.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ActiveXmaStreams")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ActiveXmaStreams;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe XAudio2PerformanceData(ulong audioCyclesSinceLastQuery = default, ulong totalCyclesSinceLastQuery = default, uint minimumCyclesPerQuantum = default, uint maximumCyclesPerQuantum = default, uint memoryUsageInBytes = default, uint currentLatencyInSamples = default, uint glitchesSinceEngineStarted = default, uint activeSourceVoiceCount = default, uint totalSourceVoiceCount = default, uint activeSubmixVoiceCount = default, uint activeResamplerCount = default, uint activeMatrixMixCount = default, uint activeXmaSourceVoices = default, uint activeXmaStreams = default)
		{
			AudioCyclesSinceLastQuery = audioCyclesSinceLastQuery;
			TotalCyclesSinceLastQuery = totalCyclesSinceLastQuery;
			MinimumCyclesPerQuantum = minimumCyclesPerQuantum;
			MaximumCyclesPerQuantum = maximumCyclesPerQuantum;
			MemoryUsageInBytes = memoryUsageInBytes;
			CurrentLatencyInSamples = currentLatencyInSamples;
			GlitchesSinceEngineStarted = glitchesSinceEngineStarted;
			ActiveSourceVoiceCount = activeSourceVoiceCount;
			TotalSourceVoiceCount = totalSourceVoiceCount;
			ActiveSubmixVoiceCount = activeSubmixVoiceCount;
			ActiveResamplerCount = activeResamplerCount;
			ActiveMatrixMixCount = activeMatrixMixCount;
			ActiveXmaSourceVoices = activeXmaSourceVoices;
			ActiveXmaStreams = activeXmaStreams;
		}


	}

}