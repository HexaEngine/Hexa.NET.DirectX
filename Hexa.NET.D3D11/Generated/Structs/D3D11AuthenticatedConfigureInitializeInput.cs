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
	[NativeName(NativeNameType.StructOrClass, "D3D11_AUTHENTICATED_CONFIGURE_INITIALIZE_INPUT")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11AuthenticatedConfigureInitializeInput
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Parameters")]
		[NativeName(NativeNameType.Type, "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
		public D3D11AuthenticatedConfigureInput Parameters;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "StartSequenceQuery")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint StartSequenceQuery;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "StartSequenceConfigure")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint StartSequenceConfigure;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11AuthenticatedConfigureInitializeInput(D3D11AuthenticatedConfigureInput parameters = default, uint startSequenceQuery = default, uint startSequenceConfigure = default)
		{
			Parameters = parameters;
			StartSequenceQuery = startSequenceQuery;
			StartSequenceConfigure = startSequenceConfigure;
		}


	}

}