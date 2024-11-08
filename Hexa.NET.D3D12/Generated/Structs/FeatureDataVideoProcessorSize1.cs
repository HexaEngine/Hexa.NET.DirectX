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
	public partial struct FeatureDataVideoProcessorSize1
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NodeMask;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoProcessOutputStreamDesc* POutputStreamDesc;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NumInputStreamDescs;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoProcessInputStreamDesc* PInputStreamDescs;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 Protected;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong MemoryPoolL0Size;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong MemoryPoolL1Size;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe FeatureDataVideoProcessorSize1(uint nodeMask = default, VideoProcessOutputStreamDesc* pOutputStreamDesc = default, uint numInputStreamDescs = default, VideoProcessInputStreamDesc* pInputStreamDescs = default, Bool32 @protected = default, ulong memoryPoolL0Size = default, ulong memoryPoolL1Size = default)
		{
			NodeMask = nodeMask;
			POutputStreamDesc = pOutputStreamDesc;
			NumInputStreamDescs = numInputStreamDescs;
			PInputStreamDescs = pInputStreamDescs;
			Protected = @protected;
			MemoryPoolL0Size = memoryPoolL0Size;
			MemoryPoolL1Size = memoryPoolL1Size;
		}


	}

}
