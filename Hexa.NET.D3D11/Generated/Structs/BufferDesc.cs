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

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// interface __MIDL_itf_d3d11_0000_0005 <br/>
	/// [local] <br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct BufferDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ByteWidth;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Usage Usage;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BindFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint CPUAccessFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MiscFlags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint StructureByteStride;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BufferDesc(uint byteWidth = default, Usage usage = default, uint bindFlags = default, uint cpuAccessFlags = default, uint miscFlags = default, uint structureByteStride = default)
		{
			ByteWidth = byteWidth;
			Usage = usage;
			BindFlags = bindFlags;
			CPUAccessFlags = cpuAccessFlags;
			MiscFlags = miscFlags;
			StructureByteStride = structureByteStride;
		}


	}

}