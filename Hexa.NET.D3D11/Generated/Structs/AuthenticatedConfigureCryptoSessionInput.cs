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
	public partial struct AuthenticatedConfigureCryptoSessionInput
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public AuthenticatedConfigureInput Parameters;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nint DecoderHandle;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nint CryptoSessionHandle;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nint DeviceHandle;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe AuthenticatedConfigureCryptoSessionInput(AuthenticatedConfigureInput parameters = default, nint decoderHandle = default, nint cryptoSessionHandle = default, nint deviceHandle = default)
		{
			Parameters = parameters;
			DecoderHandle = decoderHandle;
			CryptoSessionHandle = cryptoSessionHandle;
			DeviceHandle = deviceHandle;
		}


	}

}
