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
	public partial struct DescriptorRange1
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public DescriptorRangeType RangeType;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NumDescriptors;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BaseShaderRegister;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint RegisterSpace;

		/// <summary>
		/// To be documented.
		/// </summary>
		public DescriptorRangeFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint OffsetInDescriptorsFromTableStart;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe DescriptorRange1(DescriptorRangeType rangeType = default, uint numDescriptors = default, uint baseShaderRegister = default, uint registerSpace = default, DescriptorRangeFlags flags = default, uint offsetInDescriptorsFromTableStart = default)
		{
			RangeType = rangeType;
			NumDescriptors = numDescriptors;
			BaseShaderRegister = baseShaderRegister;
			RegisterSpace = registerSpace;
			Flags = flags;
			OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
		}


	}

}