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
	public partial struct RenderPassDepthStencilDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public CpuDescriptorHandle CpuDescriptor;

		/// <summary>
		/// To be documented.
		/// </summary>
		public RenderPassBeginningAccess DepthBeginningAccess;

		/// <summary>
		/// To be documented.
		/// </summary>
		public RenderPassBeginningAccess StencilBeginningAccess;

		/// <summary>
		/// To be documented.
		/// </summary>
		public RenderPassEndingAccess DepthEndingAccess;

		/// <summary>
		/// To be documented.
		/// </summary>
		public RenderPassEndingAccess StencilEndingAccess;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe RenderPassDepthStencilDesc(CpuDescriptorHandle cpuDescriptor = default, RenderPassBeginningAccess depthBeginningAccess = default, RenderPassBeginningAccess stencilBeginningAccess = default, RenderPassEndingAccess depthEndingAccess = default, RenderPassEndingAccess stencilEndingAccess = default)
		{
			CpuDescriptor = cpuDescriptor;
			DepthBeginningAccess = depthBeginningAccess;
			StencilBeginningAccess = stencilBeginningAccess;
			DepthEndingAccess = depthEndingAccess;
			StencilEndingAccess = stencilEndingAccess;
		}


	}

}
