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

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// interface __MIDL_itf_d3d12_0000_0018 <br/>
	/// [local] <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct WritebufferimmediateParameter
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong Dest;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Value;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe WritebufferimmediateParameter(ulong dest = default, uint value = default)
		{
			Dest = dest;
			Value = value;
		}


	}

}