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
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ClassInstanceDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint TypeId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ConstantBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BaseConstantBufferOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BaseTexture;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BaseSampler;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 Created;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ClassInstanceDesc(uint instanceId = default, uint instanceIndex = default, uint typeId = default, uint constantBuffer = default, uint baseConstantBufferOffset = default, uint baseTexture = default, uint baseSampler = default, Bool32 created = default)
		{
			InstanceId = instanceId;
			InstanceIndex = instanceIndex;
			TypeId = typeId;
			ConstantBuffer = constantBuffer;
			BaseConstantBufferOffset = baseConstantBufferOffset;
			BaseTexture = baseTexture;
			BaseSampler = baseSampler;
			Created = created;
		}


	}

}
