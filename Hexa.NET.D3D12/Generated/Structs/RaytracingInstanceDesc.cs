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
	public partial struct RaytracingInstanceDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe float* Transform_0;
		public unsafe float* Transform_1;
		public unsafe float* Transform_2;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceID;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceMask;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint InstanceContributionToHitGroupIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ulong AccelerationStructure;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe RaytracingInstanceDesc(float** transform = default, uint instanceId = default, uint instanceMask = default, uint instanceContributionToHitGroupIndex = default, uint flags = default, ulong accelerationStructure = default)
		{
			if (transform != default(float**))
			{
				Transform_0 = transform[0];
				Transform_1 = transform[1];
				Transform_2 = transform[2];
			}
			InstanceID = instanceId;
			InstanceMask = instanceMask;
			InstanceContributionToHitGroupIndex = instanceContributionToHitGroupIndex;
			Flags = flags;
			AccelerationStructure = accelerationStructure;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe RaytracingInstanceDesc(Span<Pointer<float>> transform = default, uint instanceId = default, uint instanceMask = default, uint instanceContributionToHitGroupIndex = default, uint flags = default, ulong accelerationStructure = default)
		{
			if (transform != default(Span<Pointer<float>>))
			{
				Transform_0 = transform[0];
				Transform_1 = transform[1];
				Transform_2 = transform[2];
			}
			InstanceID = instanceId;
			InstanceMask = instanceMask;
			InstanceContributionToHitGroupIndex = instanceContributionToHitGroupIndex;
			Flags = flags;
			AccelerationStructure = accelerationStructure;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<Pointer<float>> Transform
		
		{
			get
			{
				fixed (float** p = &this.Transform_0)
				{
					return new Span<Pointer<float>>(p, 3);
				}
			}
		}
	}

}
