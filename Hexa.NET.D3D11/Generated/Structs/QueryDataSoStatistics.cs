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
	public partial struct QueryDataSoStatistics
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong NumPrimitivesWritten;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong PrimitivesStorageNeeded;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe QueryDataSoStatistics(ulong numPrimitivesWritten = default, ulong primitivesStorageNeeded = default)
		{
			NumPrimitivesWritten = numPrimitivesWritten;
			PrimitivesStorageNeeded = primitivesStorageNeeded;
		}


	}

}
