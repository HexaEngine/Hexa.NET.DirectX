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
	public partial struct HeapDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong SizeInBytes;

		/// <summary>
		/// To be documented.
		/// </summary>
		public HeapProperties Properties;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong Alignment;

		/// <summary>
		/// To be documented.
		/// </summary>
		public HeapFlags Flags;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe HeapDesc(ulong sizeInBytes = default, HeapProperties properties = default, ulong alignment = default, HeapFlags flags = default)
		{
			SizeInBytes = sizeInBytes;
			Properties = properties;
			Alignment = alignment;
			Flags = flags;
		}


	}

}
