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
	[NativeName(NativeNameType.StructOrClass, "D3D12_DRED_ALLOCATION_NODE")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12DredAllocationNode
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ObjectNameA")]
		[NativeName(NativeNameType.Type, "const char*")]
		public unsafe byte* ObjectNameA;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ObjectNameW")]
		[NativeName(NativeNameType.Type, "const wchar*")]
		public unsafe char* ObjectNameW;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AllocationType")]
		[NativeName(NativeNameType.Type, "D3D12_DRED_ALLOCATION_TYPE")]
		public D3D12DredAllocationType AllocationType;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pNext")]
		[NativeName(NativeNameType.Type, "const D3D12_DRED_ALLOCATION_NODE*")]
		public unsafe D3D12DredAllocationNode* PNext;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12DredAllocationNode(byte* objectNameA = default, char* objectNameW = default, D3D12DredAllocationType allocationType = default, D3D12DredAllocationNode* pNext = default)
		{
			ObjectNameA = objectNameA;
			ObjectNameW = objectNameW;
			AllocationType = allocationType;
			PNext = pNext;
		}


	}

}