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
	[NativeName(NativeNameType.StructOrClass, "D3D11_QUERY_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11QueryDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Query")]
		[NativeName(NativeNameType.Type, "D3D11_QUERY")]
		public D3D11Query Query;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "MiscFlags")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint MiscFlags;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11QueryDesc(D3D11Query query = default, uint miscFlags = default)
		{
			Query = query;
			MiscFlags = miscFlags;
		}


	}

}