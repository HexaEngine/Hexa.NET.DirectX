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
	public partial struct InputElementDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe byte* SemanticName;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint SemanticIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Format Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InputSlot;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint AlignedByteOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public InputClassification InputSlotClass;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceDataStepRate;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe InputElementDesc(byte* semanticName = default, uint semanticIndex = default, Format format = default, uint inputSlot = default, uint alignedByteOffset = default, InputClassification inputSlotClass = default, uint instanceDataStepRate = default)
		{
			SemanticName = semanticName;
			SemanticIndex = semanticIndex;
			Format = format;
			InputSlot = inputSlot;
			AlignedByteOffset = alignedByteOffset;
			InputSlotClass = inputSlotClass;
			InstanceDataStepRate = instanceDataStepRate;
		}


	}

}
