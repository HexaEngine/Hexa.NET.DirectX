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
	[NativeName(NativeNameType.Enum, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY")]
	[Flags]
	public enum DxgiInfoQueueMessageCategory : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_UNKNOWN")]
		[NativeName(NativeNameType.Value, "0")]
		Unknown = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_MISCELLANEOUS")]
		[NativeName(NativeNameType.Value, "1")]
		Miscellaneous = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_INITIALIZATION")]
		[NativeName(NativeNameType.Value, "2")]
		Initialization = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_CLEANUP")]
		[NativeName(NativeNameType.Value, "3")]
		Cleanup = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_COMPILATION")]
		[NativeName(NativeNameType.Value, "4")]
		Compilation = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_CREATION")]
		[NativeName(NativeNameType.Value, "5")]
		StateCreation = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_SETTING")]
		[NativeName(NativeNameType.Value, "6")]
		StateSetting = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_GETTING")]
		[NativeName(NativeNameType.Value, "7")]
		StateGetting = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
		[NativeName(NativeNameType.Value, "8")]
		ResourceManipulation = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_EXECUTION")]
		[NativeName(NativeNameType.Value, "9")]
		Execution = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_SHADER")]
		[NativeName(NativeNameType.Value, "10")]
		Shader = unchecked(10),
	}
}