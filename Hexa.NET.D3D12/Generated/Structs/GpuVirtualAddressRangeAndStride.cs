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
	public partial struct GpuVirtualAddressRangeAndStride
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong StartAddress;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong SizeInBytes;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong StrideInBytes;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe GpuVirtualAddressRangeAndStride(ulong startAddress = default, ulong sizeInBytes = default, ulong strideInBytes = default)
		{
			StartAddress = startAddress;
			SizeInBytes = sizeInBytes;
			StrideInBytes = strideInBytes;
		}


	}

}