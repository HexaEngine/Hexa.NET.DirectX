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
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AesCtrIv
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong IV;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong Count;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe AesCtrIv(ulong iv = default, ulong count = default)
		{
			IV = iv;
			Count = count;
		}


	}

}