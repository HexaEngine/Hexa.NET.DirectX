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
	public enum VideoDecoderCaps : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		Downsample = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		NonRealTime = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		DownsampleDynamic = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		DownsampleRequired = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		Unsupported = unchecked(16),
	}
}