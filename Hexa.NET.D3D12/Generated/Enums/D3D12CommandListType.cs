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
	[NativeName(NativeNameType.Enum, "D3D12_COMMAND_LIST_TYPE")]
	[Flags]
	public enum D3D12CommandListType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_DIRECT")]
		[NativeName(NativeNameType.Value, "0")]
		Direct = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_BUNDLE")]
		[NativeName(NativeNameType.Value, "1")]
		Bundle = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_COMPUTE")]
		[NativeName(NativeNameType.Value, "2")]
		Compute = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_COPY")]
		[NativeName(NativeNameType.Value, "3")]
		Copy = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE")]
		[NativeName(NativeNameType.Value, "4")]
		VideoDecode = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS")]
		[NativeName(NativeNameType.Value, "5")]
		VideoProcess = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE")]
		[NativeName(NativeNameType.Value, "6")]
		VideoEncode = unchecked(6),
	}
}