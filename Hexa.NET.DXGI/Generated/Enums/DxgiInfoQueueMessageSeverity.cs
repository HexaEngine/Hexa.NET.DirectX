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
	[NativeName(NativeNameType.Enum, "DXGI_INFO_QUEUE_MESSAGE_SEVERITY")]
	[Flags]
	public enum DxgiInfoQueueMessageSeverity : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION")]
		[NativeName(NativeNameType.Value, "0")]
		Corruption = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR")]
		[NativeName(NativeNameType.Value, "1")]
		Error = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_WARNING")]
		[NativeName(NativeNameType.Value, "2")]
		Warning = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_INFO")]
		[NativeName(NativeNameType.Value, "3")]
		Info = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_MESSAGE")]
		[NativeName(NativeNameType.Value, "4")]
		Message = unchecked(4),
	}
}