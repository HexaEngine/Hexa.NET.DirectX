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
	/// Emitter:<br/>
	/// Defines a 3D audio source, divided into two classifications:<br/>
	/// Single-point -- For use with single-channel sounds.<br/>
	/// Positioned at the emitter base, i.e. the channel radius<br/>
	/// and azimuth are ignored if the number of channels == 1.<br/>
	/// May be omnidirectional or directional using a cone.<br/>
	/// The cone originates from the emitter base position,<br/>
	/// and is directed by the emitter's front orientation.<br/>
	/// Multi-point  -- For use with multi-channel sounds.<br/>
	/// Each non-LFE channel is positioned using an<br/>
	/// azimuth along the channel radius with respect to the<br/>
	/// front orientation vector in the plane orthogonal to the<br/>
	/// top orientation vector.  An azimuth of X3DAUDIO_2PI<br/>
	/// specifies a channel is an LFE.  Such channels are<br/>
	/// positioned at the emitter base and are calculated<br/>
	/// with respect to pLFECurve only, never pVolumeCurve.<br/>
	/// Multi-point emitters are always omnidirectional,<br/>
	/// i.e. the cone is ignored if the number of channels > 1.<br/>
	/// Note that many properties are shared among all channel points,<br/>
	/// locking certain behaviour with respect to the emitter base position.<br/>
	/// For example, doppler shift is always calculated with respect to the<br/>
	/// emitter base position and so is constant for all its channel points.<br/>
	/// Distance curve calculations are also with respect to the emitter base<br/>
	/// position, with the curves being calculated independently of each other.<br/>
	/// For instance, volume and LFE calculations do not affect one another.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "X3DAUDIO_EMITTER")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct X3DAudioEmitter
	{
		/// <summary>
		/// sound cone, used only with single-channel emitters for matrix, LPF (both direct and reverb paths), and reverb calculations, NULL specifies omnidirectionality<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pCone")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_CONE*")]
		public unsafe X3DAudioCone* PCone;

		/// <summary>
		/// orientation of front direction, used only for emitter angle calculations or with multi-channel emitters for matrix calculations or single-channel emitters with cones for matrix, LPF (both direct and reverb paths), and reverb calculations, must be normalized when used<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "OrientFront")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_VECTOR")]
		public Vector3 OrientFront;

		/// <summary>
		/// orientation of top direction, used only with multi-channel emitters for matrix calculations, must be orthonormal with OrientFront when used<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "OrientTop")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_VECTOR")]
		public Vector3 OrientTop;

		/// <summary>
		/// position in user-defined world units, does not affect Velocity<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Position")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_VECTOR")]
		public Vector3 Position;

		/// <summary>
		/// velocity vector in user-defined world units/second, used only for doppler calculations, does not affect Position<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Velocity")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_VECTOR")]
		public Vector3 Velocity;

		/// <summary>
		/// inner radius, must be within [0.0f, FLT_MAX]<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "InnerRadius")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float InnerRadius;

		/// <summary>
		/// inner radius angle, must be within [0.0f, X3DAUDIO_PI/4.0)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "InnerRadiusAngle")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float InnerRadiusAngle;

		/// <summary>
		/// number of sound channels, must be > 0<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ChannelCount")]
		[NativeName(NativeNameType.Type, "UINT32")]
		public uint ChannelCount;

		/// <summary>
		/// channel radius, used only with multi-channel emitters for matrix calculations, must be >= 0.0f when used<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ChannelRadius")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float ChannelRadius;

		/// <summary>
		/// channel azimuth array, used only with multi-channel emitters for matrix calculations, contains positions of each channel expressed in radians along the channel radius with respect to the front orientation vector in the plane orthogonal to the top orientation vector, or X3DAUDIO_2PI to specify an LFE channel, must have at least ChannelCount elements, all within [0.0f, X3DAUDIO_2PI] when used<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pChannelAzimuths")]
		[NativeName(NativeNameType.Type, "FLOAT32*")]
		public unsafe float* PChannelAzimuths;

		/// <summary>
		/// volume level distance curve, used only for matrix calculations, NULL specifies a default curve that conforms to the inverse square law, calculated in user-defined world units with distances <br/>
		/// <<br/>
		/// = CurveDistanceScaler clamped to no attenuation<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pVolumeCurve")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_DISTANCE_CURVE*")]
		public unsafe X3DAudioDistanceCurve* PVolumeCurve;

		/// <summary>
		/// LFE level distance curve, used only for matrix calculations, NULL specifies a default curve that conforms to the inverse square law, calculated in user-defined world units with distances <br/>
		/// <<br/>
		/// = CurveDistanceScaler clamped to no attenuation<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pLFECurve")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_DISTANCE_CURVE*")]
		public unsafe X3DAudioDistanceCurve* PLFECurve;

		/// <summary>
		/// LPF direct-path coefficient distance curve, used only for LPF direct-path calculations, NULL specifies the default curve: [0.0f,1.0f], [1.0f,0.75f]<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pLPFDirectCurve")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_DISTANCE_CURVE*")]
		public unsafe X3DAudioDistanceCurve* PLPFDirectCurve;

		/// <summary>
		/// LPF reverb-path coefficient distance curve, used only for LPF reverb-path calculations, NULL specifies the default curve: [0.0f,0.75f], [1.0f,0.75f]<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pLPFReverbCurve")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_DISTANCE_CURVE*")]
		public unsafe X3DAudioDistanceCurve* PLPFReverbCurve;

		/// <summary>
		/// reverb send level distance curve, used only for reverb calculations, NULL specifies the default curve: [0.0f,1.0f], [1.0f,0.0f]<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "pReverbCurve")]
		[NativeName(NativeNameType.Type, "X3DAUDIO_DISTANCE_CURVE*")]
		public unsafe X3DAudioDistanceCurve* PReverbCurve;

		/// <summary>
		/// curve distance scaler, used to scale normalized distance curves to user-defined world units and/or exaggerate their effect, used only for matrix, LPF (both direct and reverb paths), and reverb calculations, must be within [FLT_MIN, FLT_MAX] when used<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "CurveDistanceScaler")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float CurveDistanceScaler;

		/// <summary>
		/// doppler shift scaler, used to exaggerate doppler shift effect, used only for doppler calculations, must be within [0.0f, FLT_MAX] when used<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "DopplerScaler")]
		[NativeName(NativeNameType.Type, "FLOAT32")]
		public float DopplerScaler;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe X3DAudioEmitter(X3DAudioCone* pCone = default, Vector3 orientFront = default, Vector3 orientTop = default, Vector3 position = default, Vector3 velocity = default, float innerRadius = default, float innerRadiusAngle = default, uint channelCount = default, float channelRadius = default, float* pChannelAzimuths = default, X3DAudioDistanceCurve* pVolumeCurve = default, X3DAudioDistanceCurve* pLFECurve = default, X3DAudioDistanceCurve* pLPFDirectCurve = default, X3DAudioDistanceCurve* pLPFReverbCurve = default, X3DAudioDistanceCurve* pReverbCurve = default, float curveDistanceScaler = default, float dopplerScaler = default)
		{
			PCone = pCone;
			OrientFront = orientFront;
			OrientTop = orientTop;
			Position = position;
			Velocity = velocity;
			InnerRadius = innerRadius;
			InnerRadiusAngle = innerRadiusAngle;
			ChannelCount = channelCount;
			ChannelRadius = channelRadius;
			PChannelAzimuths = pChannelAzimuths;
			PVolumeCurve = pVolumeCurve;
			PLFECurve = pLFECurve;
			PLPFDirectCurve = pLPFDirectCurve;
			PLPFReverbCurve = pLPFReverbCurve;
			PReverbCurve = pReverbCurve;
			CurveDistanceScaler = curveDistanceScaler;
			DopplerScaler = dopplerScaler;
		}


	}

}
