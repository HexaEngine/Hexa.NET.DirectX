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
	public partial struct BufferBarrier
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public BarrierSync SyncBefore;

		/// <summary>
		/// To be documented.
		/// </summary>
		public BarrierSync SyncAfter;

		/// <summary>
		/// To be documented.
		/// </summary>
		public BarrierAccess AccessBefore;

		/// <summary>
		/// To be documented.
		/// </summary>
		public BarrierAccess AccessAfter;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ID3D12Resource* PResource;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong Offset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong Size;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BufferBarrier(BarrierSync syncBefore = default, BarrierSync syncAfter = default, BarrierAccess accessBefore = default, BarrierAccess accessAfter = default, ID3D12Resource* pResource = default, ulong offset = default, ulong size = default)
		{
			SyncBefore = syncBefore;
			SyncAfter = syncAfter;
			AccessBefore = accessBefore;
			AccessAfter = accessAfter;
			PResource = pResource;
			Offset = offset;
			Size = size;
		}


	}

}
