// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "D3D12_RAYTRACING_PIPELINE_FLAGS")]
	[Flags]
	public enum D3D12RaytracingPipelineFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RAYTRACING_PIPELINE_FLAG_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		FlagNone = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES")]
		[NativeName(NativeNameType.Value, "256")]
		FlagSkipTriangles = unchecked(256),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES")]
		[NativeName(NativeNameType.Value, "512")]
		FlagSkipProceduralPrimitives = unchecked(512),
	}
}