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
	public partial struct FeatureDataVideoExtensionCommandSupport
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint NodeIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Guid CommandId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PInputData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nuint InputDataSizeInBytes;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* POutputData;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nuint OutputDataSizeInBytes;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe FeatureDataVideoExtensionCommandSupport(uint nodeIndex = default, Guid commandId = default, void* pInputData = default, nuint inputDataSizeInBytes = default, void* pOutputData = default, nuint outputDataSizeInBytes = default)
		{
			NodeIndex = nodeIndex;
			CommandId = commandId;
			PInputData = pInputData;
			InputDataSizeInBytes = inputDataSizeInBytes;
			POutputData = pOutputData;
			OutputDataSizeInBytes = outputDataSizeInBytes;
		}


	}

}