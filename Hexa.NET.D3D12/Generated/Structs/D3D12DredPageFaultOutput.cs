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
	[NativeName(NativeNameType.StructOrClass, "D3D12_DRED_PAGE_FAULT_OUTPUT")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12DredPageFaultOutput
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "PageFaultVA")]
		[NativeName(NativeNameType.Type, "D3D12_GPU_VIRTUAL_ADDRESS")]
		public ulong PageFaultVA;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pHeadExistingAllocationNode")]
		[NativeName(NativeNameType.Type, "const D3D12_DRED_ALLOCATION_NODE*")]
		public unsafe D3D12DredAllocationNode* PHeadExistingAllocationNode;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pHeadRecentFreedAllocationNode")]
		[NativeName(NativeNameType.Type, "const D3D12_DRED_ALLOCATION_NODE*")]
		public unsafe D3D12DredAllocationNode* PHeadRecentFreedAllocationNode;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12DredPageFaultOutput(ulong pageFaultVa = default, D3D12DredAllocationNode* pHeadExistingAllocationNode = default, D3D12DredAllocationNode* pHeadRecentFreedAllocationNode = default)
		{
			PageFaultVA = pageFaultVa;
			PHeadExistingAllocationNode = pHeadExistingAllocationNode;
			PHeadRecentFreedAllocationNode = pHeadRecentFreedAllocationNode;
		}


	}

}