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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VIEW_INSTANCE_LOCATION")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12ViewInstanceLocation
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ViewportArrayIndex")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint ViewportArrayIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "RenderTargetArrayIndex")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint RenderTargetArrayIndex;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12ViewInstanceLocation(uint viewportArrayIndex = default, uint renderTargetArrayIndex = default)
		{
			ViewportArrayIndex = viewportArrayIndex;
			RenderTargetArrayIndex = renderTargetArrayIndex;
		}


	}

}