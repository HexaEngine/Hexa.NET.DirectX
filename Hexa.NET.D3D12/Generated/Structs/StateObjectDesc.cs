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
	public partial struct StateObjectDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public StateObjectType Type;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NumSubobjects;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StateSubobject* PSubobjects;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe StateObjectDesc(StateObjectType type = default, uint numSubobjects = default, StateSubobject* pSubobjects = default)
		{
			Type = type;
			NumSubobjects = numSubobjects;
			PSubobjects = pSubobjects;
		}


	}

}
