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
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "_DXGI_RECLAIM_RESOURCE_RESULTS")]
	[Flags]
	public enum DxgiReclaimResourceResults : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_RECLAIM_RESOURCE_RESULT_OK")]
		[NativeName(NativeNameType.Value, "0")]
		ResultOk = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED")]
		[NativeName(NativeNameType.Value, "1")]
		ResultDiscarded = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED")]
		[NativeName(NativeNameType.Value, "2")]
		ResultNotCommitted = unchecked(2),
	}
}