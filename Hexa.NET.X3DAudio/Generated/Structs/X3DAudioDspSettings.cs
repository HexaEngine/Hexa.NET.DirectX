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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.X3DAudio
{
	/// <summary>
	/// DSP settings:<br/>
	/// Receives results from a call to X3DAudioCalculate to be sent<br/>
	/// to the low-level audio rendering API for 3D signal processing.<br/>
	/// The user is responsible for allocating the matrix coefficient table,<br/>
	/// delay time array, and initializing the channel counts when used.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "X3DAUDIO_DSP_SETTINGS")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct X3DAudioDspSettings
	{
		/// <summary>
		/// [inout] matrix coefficient table, receives an array representing the volume level used to send from source channel S to destination channel D, stored as pMatrixCoefficients[SrcChannelCount * D + S], must have at least SrcChannelCount*DstChannelCount elements<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pMatrixCoefficients")]
		[NativeName(NativeNameType.Type, "FLOAT32*")]
		public unsafe float* PMatrixCoefficients;

		/// <summary>
		/// [inout] delay time array, receives delays for each destination channel in milliseconds, must have at least DstChannelCount elements (stereo final mix only)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pDelayTimes")]
		[NativeName(NativeNameType.Type, "FLOAT32*")]
		public unsafe float* PDelayTimes;

		/// <summary>
		/// [in] number of source channels, must equal number of channels in respective emitter<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SrcChannelCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint SrcChannelCount;

		/// <summary>
		/// [in] number of destination channels, must equal number of channels of the final mix<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "DstChannelCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint DstChannelCount;

		/// <summary>
		/// [out] LPF direct-path coefficient<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "LPFDirectCoefficient")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float LPFDirectCoefficient;

		/// <summary>
		/// [out] LPF reverb-path coefficient<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "LPFReverbCoefficient")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float LPFReverbCoefficient;

		/// <summary>
		/// [out] reverb send level<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ReverbLevel")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float ReverbLevel;

		/// <summary>
		/// [out] doppler shift factor, scales resampler ratio for doppler shift effect, where the effective frequency = DopplerFactor * original frequency<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "DopplerFactor")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float DopplerFactor;

		/// <summary>
		/// [out] emitter-to-listener interior angle, expressed in radians with respect to the emitter's front orientation<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "EmitterToListenerAngle")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float EmitterToListenerAngle;

		/// <summary>
		/// [out] distance in user-defined world units from the emitter base to listener position, always calculated<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "EmitterToListenerDistance")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float EmitterToListenerDistance;

		/// <summary>
		/// [out] component of emitter velocity vector projected onto emitter->listener vector in user-defined world units/second, calculated only for doppler<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "EmitterVelocityComponent")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float EmitterVelocityComponent;

		/// <summary>
		/// [out] component of listener velocity vector projected onto emitter->listener vector in user-defined world units/second, calculated only for doppler<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ListenerVelocityComponent")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float ListenerVelocityComponent;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe X3DAudioDspSettings(float* pMatrixCoefficients = default, float* pDelayTimes = default, uint srcChannelCount = default, uint dstChannelCount = default, float lpfDirectCoefficient = default, float lpfReverbCoefficient = default, float reverbLevel = default, float dopplerFactor = default, float emitterToListenerAngle = default, float emitterToListenerDistance = default, float emitterVelocityComponent = default, float listenerVelocityComponent = default)
		{
			PMatrixCoefficients = pMatrixCoefficients;
			PDelayTimes = pDelayTimes;
			SrcChannelCount = srcChannelCount;
			DstChannelCount = dstChannelCount;
			LPFDirectCoefficient = lpfDirectCoefficient;
			LPFReverbCoefficient = lpfReverbCoefficient;
			ReverbLevel = reverbLevel;
			DopplerFactor = dopplerFactor;
			EmitterToListenerAngle = emitterToListenerAngle;
			EmitterToListenerDistance = emitterToListenerDistance;
			EmitterVelocityComponent = emitterVelocityComponent;
			ListenerVelocityComponent = listenerVelocityComponent;
		}


	}

}