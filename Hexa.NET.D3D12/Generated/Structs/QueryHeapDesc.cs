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
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct QueryHeapDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public QueryHeapType Type;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Count;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NodeMask;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe QueryHeapDesc(QueryHeapType type = default, uint count = default, uint nodeMask = default)
		{
			Type = type;
			Count = count;
			NodeMask = nodeMask;
		}


	}

}