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
	/// interface __MIDL_itf_d3d12_0000_0049 <br/>
	/// [local] <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct DispatchRaysDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public GpuVirtualAddressRange RayGenerationShaderRecord;

		/// <summary>
		/// To be documented.
		/// </summary>
		public GpuVirtualAddressRangeAndStride MissShaderTable;

		/// <summary>
		/// To be documented.
		/// </summary>
		public GpuVirtualAddressRangeAndStride HitGroupTable;

		/// <summary>
		/// To be documented.
		/// </summary>
		public GpuVirtualAddressRangeAndStride CallableShaderTable;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Width;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Height;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Depth;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe DispatchRaysDesc(GpuVirtualAddressRange rayGenerationShaderRecord = default, GpuVirtualAddressRangeAndStride missShaderTable = default, GpuVirtualAddressRangeAndStride hitGroupTable = default, GpuVirtualAddressRangeAndStride callableShaderTable = default, uint width = default, uint height = default, uint depth = default)
		{
			RayGenerationShaderRecord = rayGenerationShaderRecord;
			MissShaderTable = missShaderTable;
			HitGroupTable = hitGroupTable;
			CallableShaderTable = callableShaderTable;
			Width = width;
			Height = height;
			Depth = depth;
		}


	}

}
