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

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "D3D11_COUNTER_INFO")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11CounterInfo
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "LastDeviceDependentCounter")]
		[NativeName(NativeNameType.Type, "D3D11_COUNTER")]
		public D3D11Counter LastDeviceDependentCounter;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NumSimultaneousCounters")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NumSimultaneousCounters;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NumDetectableParallelUnits")]
		[NativeName(NativeNameType.Type, "UINT8")]
		public byte NumDetectableParallelUnits;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11CounterInfo(D3D11Counter lastDeviceDependentCounter = default, uint numSimultaneousCounters = default, byte numDetectableParallelUnits = default)
		{
			LastDeviceDependentCounter = lastDeviceDependentCounter;
			NumSimultaneousCounters = numSimultaneousCounters;
			NumDetectableParallelUnits = numDetectableParallelUnits;
		}


	}

}