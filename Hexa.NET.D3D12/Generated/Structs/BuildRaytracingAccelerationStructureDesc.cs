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
	public partial struct BuildRaytracingAccelerationStructureDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong DestAccelerationStructureData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public BuildRaytracingAccelerationStructureInputs Inputs;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong SourceAccelerationStructureData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong ScratchAccelerationStructureData;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BuildRaytracingAccelerationStructureDesc(ulong destAccelerationStructureData = default, BuildRaytracingAccelerationStructureInputs inputs = default, ulong sourceAccelerationStructureData = default, ulong scratchAccelerationStructureData = default)
		{
			DestAccelerationStructureData = destAccelerationStructureData;
			Inputs = inputs;
			SourceAccelerationStructureData = sourceAccelerationStructureData;
			ScratchAccelerationStructureData = scratchAccelerationStructureData;
		}


	}

}