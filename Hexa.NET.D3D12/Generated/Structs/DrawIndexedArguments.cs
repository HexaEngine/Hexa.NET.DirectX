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
	public partial struct DrawIndexedArguments
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint IndexCountPerInstance;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceCount;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint StartIndexLocation;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int BaseVertexLocation;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint StartInstanceLocation;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe DrawIndexedArguments(uint indexCountPerInstance = default, uint instanceCount = default, uint startIndexLocation = default, int baseVertexLocation = default, uint startInstanceLocation = default)
		{
			IndexCountPerInstance = indexCountPerInstance;
			InstanceCount = instanceCount;
			StartIndexLocation = startIndexLocation;
			BaseVertexLocation = baseVertexLocation;
			StartInstanceLocation = startInstanceLocation;
		}


	}

}