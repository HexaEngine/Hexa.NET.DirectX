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
	[NativeName(NativeNameType.StructOrClass, "D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12FeatureDataProtectedResourceSessionTypes
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NodeIndex")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint NodeIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Count")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Count;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pTypes")]
		[NativeName(NativeNameType.Type, "GUID*")]
		public unsafe Guid* PTypes;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12FeatureDataProtectedResourceSessionTypes(uint nodeIndex = default, uint count = default, Guid* pTypes = default)
		{
			NodeIndex = nodeIndex;
			Count = count;
			PTypes = pTypes;
		}


	}

}