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
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VideoEncoderRateControlCqp
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ConstantQP_FullIntracodedFrame")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint ConstantQPFullIntracodedFrame;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ConstantQP_InterPredictedFrame_PrevRefOnly")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint ConstantQPInterPredictedFramePrevRefOnly;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ConstantQP_InterPredictedFrame_BiDirectionalRef")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint ConstantQPInterPredictedFrameBiDirectionalRef;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VideoEncoderRateControlCqp(uint constantqpFullintracodedframe = default, uint constantqpInterpredictedframePrevrefonly = default, uint constantqpInterpredictedframeBidirectionalref = default)
		{
			ConstantQPFullIntracodedFrame = constantqpFullintracodedframe;
			ConstantQPInterPredictedFramePrevRefOnly = constantqpInterpredictedframePrevrefonly;
			ConstantQPInterPredictedFrameBiDirectionalRef = constantqpInterpredictedframeBidirectionalref;
		}


	}

}