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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct MappedRect
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public int Pitch;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe byte* PBits;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe MappedRect(int pitch = default, byte* pBits = default)
		{
			Pitch = pitch;
			PBits = pBits;
		}


	}

}
