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
	/// interface __MIDL_itf_d3d12_0000_0055 <br/>
	/// [local] <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SubresourceData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nint RowPitch;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nint SlicePitch;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SubresourceData(void* pData = default, nint rowPitch = default, nint slicePitch = default)
		{
			PData = pData;
			RowPitch = rowPitch;
			SlicePitch = slicePitch;
		}


	}

}
