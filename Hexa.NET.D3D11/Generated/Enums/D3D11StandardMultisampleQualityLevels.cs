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
	/// interface __MIDL_itf_d3d11_0000_0026 <br/>
	/// [local] <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS")]
	[Flags]
	public enum D3D11StandardMultisampleQualityLevels : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_STANDARD_MULTISAMPLE_PATTERN")]
		[NativeName(NativeNameType.Value, "0xffffffff")]
		Pattern = unchecked((int)0xffffffff),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_CENTER_MULTISAMPLE_PATTERN")]
		[NativeName(NativeNameType.Value, "0xfffffffe")]
		CenterMultisamplePattern = unchecked((int)0xfffffffe),
	}
}