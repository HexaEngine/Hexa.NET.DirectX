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
	public partial struct BufferexSrv
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint FirstElement;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NumElements;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Flags;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BufferexSrv(uint firstElement = default, uint numElements = default, uint flags = default)
		{
			FirstElement = firstElement;
			NumElements = numElements;
			Flags = flags;
		}


	}

}