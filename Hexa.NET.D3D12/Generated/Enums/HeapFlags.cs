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
	public enum HeapFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		FlagNone = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagShared = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagDenyBuffers = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowDisplay = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagSharedCrossAdapter = unchecked(32),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagDenyRtDsTextures = unchecked(64),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagDenyNonRtDsTextures = unchecked(128),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagHardwareProtected = unchecked(256),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowWriteWatch = unchecked(512),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowShaderAtomics = unchecked(1024),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagCreateNotResident = unchecked(2048),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagCreateNotZeroed = unchecked(4096),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowAllBuffersAndTextures = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowOnlyBuffers = unchecked(192),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowOnlyNonRtDsTextures = unchecked(68),

		/// <summary>
		/// To be documented.
		/// </summary>
		FlagAllowOnlyRtDsTextures = unchecked(132),
	}
}