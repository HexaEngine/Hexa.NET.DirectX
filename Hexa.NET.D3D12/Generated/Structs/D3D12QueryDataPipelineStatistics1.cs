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
	[NativeName(NativeNameType.StructOrClass, "D3D12_QUERY_DATA_PIPELINE_STATISTICS1")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12QueryDataPipelineStatistics1
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "IAVertices")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong IAVertices;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "IAPrimitives")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong IAPrimitives;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "VSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong VSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "GSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong GSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "GSPrimitives")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong GSPrimitives;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "CInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong CInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "CPrimitives")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong CPrimitives;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "PSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong PSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "HSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong HSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "DSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong DSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "CSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong CSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ASInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong ASInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "MSInvocations")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong MSInvocations;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "MSPrimitives")]
		[NativeName(NativeNameType.Type, "UINT64")]
		public ulong MSPrimitives;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12QueryDataPipelineStatistics1(ulong iaVertices = default, ulong iaPrimitives = default, ulong vsInvocations = default, ulong gsInvocations = default, ulong gsPrimitives = default, ulong cInvocations = default, ulong cPrimitives = default, ulong psInvocations = default, ulong hsInvocations = default, ulong dsInvocations = default, ulong csInvocations = default, ulong asInvocations = default, ulong msInvocations = default, ulong msPrimitives = default)
		{
			IAVertices = iaVertices;
			IAPrimitives = iaPrimitives;
			VSInvocations = vsInvocations;
			GSInvocations = gsInvocations;
			GSPrimitives = gsPrimitives;
			CInvocations = cInvocations;
			CPrimitives = cPrimitives;
			PSInvocations = psInvocations;
			HSInvocations = hsInvocations;
			DSInvocations = dsInvocations;
			CSInvocations = csInvocations;
			ASInvocations = asInvocations;
			MSInvocations = msInvocations;
			MSPrimitives = msPrimitives;
		}


	}

}