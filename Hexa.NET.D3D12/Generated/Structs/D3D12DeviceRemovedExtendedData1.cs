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
	[NativeName(NativeNameType.StructOrClass, "D3D12_DEVICE_REMOVED_EXTENDED_DATA1")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12DeviceRemovedExtendedData1
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DeviceRemovedReason")]
		[NativeName(NativeNameType.Type, "HRESULT")]
		public int DeviceRemovedReason;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AutoBreadcrumbsOutput")]
		[NativeName(NativeNameType.Type, "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT")]
		public D3D12DredAutoBreadcrumbsOutput AutoBreadcrumbsOutput;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "PageFaultOutput")]
		[NativeName(NativeNameType.Type, "D3D12_DRED_PAGE_FAULT_OUTPUT")]
		public D3D12DredPageFaultOutput PageFaultOutput;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12DeviceRemovedExtendedData1(int deviceRemovedReason = default, D3D12DredAutoBreadcrumbsOutput autoBreadcrumbsOutput = default, D3D12DredPageFaultOutput pageFaultOutput = default)
		{
			DeviceRemovedReason = deviceRemovedReason;
			AutoBreadcrumbsOutput = autoBreadcrumbsOutput;
			PageFaultOutput = pageFaultOutput;
		}


	}

}