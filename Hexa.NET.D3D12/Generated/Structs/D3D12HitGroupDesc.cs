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
	[NativeName(NativeNameType.StructOrClass, "D3D12_HIT_GROUP_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12HitGroupDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "HitGroupExport")]
		[NativeName(NativeNameType.Type, "LPCWSTR")]
		public unsafe char* HitGroupExport;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Type")]
		[NativeName(NativeNameType.Type, "D3D12_HIT_GROUP_TYPE")]
		public D3D12HitGroupType Type;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AnyHitShaderImport")]
		[NativeName(NativeNameType.Type, "LPCWSTR")]
		public unsafe char* AnyHitShaderImport;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ClosestHitShaderImport")]
		[NativeName(NativeNameType.Type, "LPCWSTR")]
		public unsafe char* ClosestHitShaderImport;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "IntersectionShaderImport")]
		[NativeName(NativeNameType.Type, "LPCWSTR")]
		public unsafe char* IntersectionShaderImport;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12HitGroupDesc(char* hitGroupExport = default, D3D12HitGroupType type = default, char* anyHitShaderImport = default, char* closestHitShaderImport = default, char* intersectionShaderImport = default)
		{
			HitGroupExport = hitGroupExport;
			Type = type;
			AnyHitShaderImport = anyHitShaderImport;
			ClosestHitShaderImport = closestHitShaderImport;
			IntersectionShaderImport = intersectionShaderImport;
		}


	}

}