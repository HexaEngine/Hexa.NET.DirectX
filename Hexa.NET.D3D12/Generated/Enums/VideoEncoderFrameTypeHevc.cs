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
	public enum VideoEncoderFrameTypeHevc : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		IFrame = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		PFrame = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		BFrame = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		IdrFrame = unchecked(3),
	}
}