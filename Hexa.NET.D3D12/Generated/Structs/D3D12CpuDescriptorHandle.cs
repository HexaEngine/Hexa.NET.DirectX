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
	[NativeName(NativeNameType.StructOrClass, "D3D12_CPU_DESCRIPTOR_HANDLE")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12CpuDescriptorHandle
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ptr")]
		[NativeName(NativeNameType.Type, "SIZE_T")]
		public nuint Ptr;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12CpuDescriptorHandle(nuint ptr = default)
		{
			Ptr = ptr;
		}


	}

}