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
	[NativeName(NativeNameType.StructOrClass, "D3D12_GLOBAL_ROOT_SIGNATURE")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12GlobalRootSignature
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pGlobalRootSignature")]
		[NativeName(NativeNameType.Type, "ID3D12RootSignature*")]
		public unsafe ID3D12RootSignature* PGlobalRootSignature;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12GlobalRootSignature(ID3D12RootSignature* pGlobalRootSignature = default)
		{
			PGlobalRootSignature = pGlobalRootSignature;
		}


	}

}