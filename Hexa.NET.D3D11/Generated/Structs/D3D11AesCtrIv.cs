// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "_D3D11_AES_CTR_IV")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11AesCtrIv
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "IV")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong IV;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Count")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong Count;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11AesCtrIv(ulong iv = default, ulong count = default)
		{
			IV = iv;
			Count = count;
		}


	}

}