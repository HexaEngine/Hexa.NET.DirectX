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

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum FormatSupport2 : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		UavAtomicAdd = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavAtomicBitwiseOps = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavAtomicCompareStoreOrCompareExchange = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavAtomicExchange = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavAtomicSignedMinOrMax = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavAtomicUnsignedMinOrMax = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavTypedLoad = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		UavTypedStore = unchecked(128),

		/// <summary>
		/// To be documented.
		/// </summary>
		OutputMergerLogicOp = unchecked(256),

		/// <summary>
		/// To be documented.
		/// </summary>
		Tiled = unchecked(512),

		/// <summary>
		/// To be documented.
		/// </summary>
		Shareable = unchecked(1024),

		/// <summary>
		/// To be documented.
		/// </summary>
		MultiplaneOverlay = unchecked(16384),
	}
}