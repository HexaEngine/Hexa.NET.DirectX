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
	[NativeName(NativeNameType.Enum, "D3D11_CRYPTO_SESSION_STATUS")]
	[Flags]
	public enum D3D11CryptoSessionStatus : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_CRYPTO_SESSION_STATUS_OK")]
		[NativeName(NativeNameType.Value, "0")]
		Ok = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_CRYPTO_SESSION_STATUS_KEY_LOST")]
		[NativeName(NativeNameType.Value, "1")]
		KeyLost = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST")]
		[NativeName(NativeNameType.Value, "2")]
		KeyAndContentLost = unchecked(2),
	}
}