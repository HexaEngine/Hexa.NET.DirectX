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
	public partial struct Tex2DVpiv
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MipSlice;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ArraySlice;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Tex2DVpiv(uint mipSlice = default, uint arraySlice = default)
		{
			MipSlice = mipSlice;
			ArraySlice = arraySlice;
		}


	}

}
