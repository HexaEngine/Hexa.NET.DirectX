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
	[NativeName(NativeNameType.StructOrClass, "D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12VersionedDeviceRemovedExtendedData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA::")]
		[StructLayout(LayoutKind.Explicit)]
		public partial struct D3D12VersionedDeviceRemovedExtendedDataUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Dred_1_0")]
			[NativeName(NativeNameType.Type, "D3D12_DEVICE_REMOVED_EXTENDED_DATA")]
			[FieldOffset(0)]
			public D3D12DeviceRemovedExtendedData Dred10;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Dred_1_1")]
			[NativeName(NativeNameType.Type, "D3D12_DEVICE_REMOVED_EXTENDED_DATA1")]
			[FieldOffset(0)]
			public D3D12DeviceRemovedExtendedData1 Dred11;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Dred_1_2")]
			[NativeName(NativeNameType.Type, "D3D12_DEVICE_REMOVED_EXTENDED_DATA2")]
			[FieldOffset(0)]
			public D3D12DeviceRemovedExtendedData2 Dred12;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "Dred_1_3")]
			[NativeName(NativeNameType.Type, "D3D12_DEVICE_REMOVED_EXTENDED_DATA3")]
			[FieldOffset(0)]
			public D3D12DeviceRemovedExtendedData3 Dred13;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe D3D12VersionedDeviceRemovedExtendedDataUnion(D3D12DeviceRemovedExtendedData dred10 = default, D3D12DeviceRemovedExtendedData1 dred11 = default, D3D12DeviceRemovedExtendedData2 dred12 = default, D3D12DeviceRemovedExtendedData3 dred13 = default)
			{
				Dred10 = dred10;
				Dred11 = dred11;
				Dred12 = dred12;
				Dred13 = dred13;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Version")]
		[NativeName(NativeNameType.Type, "D3D12_DRED_VERSION")]
		public D3D12DredVersion Version;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "")]
		[NativeName(NativeNameType.Type, "")]
		public D3D12VersionedDeviceRemovedExtendedDataUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12VersionedDeviceRemovedExtendedData(D3D12DredVersion version = default, D3D12VersionedDeviceRemovedExtendedDataUnion union = default)
		{
			Version = version;
			Union = union;
		}


	}

}