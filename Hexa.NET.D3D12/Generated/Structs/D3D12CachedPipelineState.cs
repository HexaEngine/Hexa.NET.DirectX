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
	[NativeName(NativeNameType.StructOrClass, "D3D12_CACHED_PIPELINE_STATE")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12CachedPipelineState
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "pCachedBlob")]
		[NativeName(NativeNameType.Type, "const void*")]
		public unsafe void* PCachedBlob;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "CachedBlobSizeInBytes")]
		[NativeName(NativeNameType.Type, "SIZE_T")]
		public nuint CachedBlobSizeInBytes;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12CachedPipelineState(void* pCachedBlob = default, nuint cachedBlobSizeInBytes = default)
		{
			PCachedBlob = pCachedBlob;
			CachedBlobSizeInBytes = cachedBlobSizeInBytes;
		}


	}

}