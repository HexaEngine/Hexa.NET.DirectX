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
	public partial struct VideoEncoderEncodeOperationMetadataBuffer
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ID3D12Resource* PBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong Offset;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoEncoderEncodeOperationMetadataBuffer(ID3D12Resource* pBuffer = default, ulong offset = default)
		{
			PBuffer = pBuffer;
			Offset = offset;
		}


	}

}