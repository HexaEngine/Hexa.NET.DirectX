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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// interface __MIDL_itf_dxgi1_2_0000_0007 <br/>
	/// [local] <br/>
	/// </summary>
	[Flags]
	public enum GraphicsPreemptionGranularity : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		DmaBufferBoundary = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		PrimitiveBoundary = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		TriangleBoundary = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		PixelBoundary = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		InstructionBoundary = unchecked(4),
	}
}
