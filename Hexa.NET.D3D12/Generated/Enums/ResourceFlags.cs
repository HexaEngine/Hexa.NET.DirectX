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

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum ResourceFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		FlagNone = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowRenderTarget = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowDepthStencil = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowUnorderedAccess = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagDenyShaderResource = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowCrossAdapter = unchecked(16),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowSimultaneousAccess = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagVideoDecodeReferenceOnly = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagVideoEncodeReferenceOnly = unchecked(128),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagRaytracingAccelerationStructure = unchecked(256),
	}
}