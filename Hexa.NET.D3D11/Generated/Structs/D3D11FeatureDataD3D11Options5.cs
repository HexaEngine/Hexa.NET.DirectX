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
	[NativeName(NativeNameType.StructOrClass, "D3D11_FEATURE_DATA_D3D11_OPTIONS5")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11FeatureDataD3D11Options5
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "SharedResourceTier")]
		[NativeName(NativeNameType.Type, "D3D11_SHARED_RESOURCE_TIER")]
		public D3D11SharedResourceTier SharedResourceTier;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11FeatureDataD3D11Options5(D3D11SharedResourceTier sharedResourceTier = default)
		{
			SharedResourceTier = sharedResourceTier;
		}


	}

}