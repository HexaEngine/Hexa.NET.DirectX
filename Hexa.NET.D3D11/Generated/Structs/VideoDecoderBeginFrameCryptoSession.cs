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
	public partial struct VideoDecoderBeginFrameCryptoSession
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ID3D11CryptoSession* PCryptoSession;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BlobSize;

		/// <summary>
		/// [annotation] <br/>
		/// </summary>
		public unsafe void* PBlob;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Guid* PKeyInfoId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint PrivateDataSize;

		/// <summary>
		/// [annotation] <br/>
		/// </summary>
		public unsafe void* PPrivateData;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoDecoderBeginFrameCryptoSession(ID3D11CryptoSession* pCryptoSession = default, uint blobSize = default, void* pBlob = default, Guid* pKeyInfoId = default, uint privateDataSize = default, void* pPrivateData = default)
		{
			PCryptoSession = pCryptoSession;
			BlobSize = blobSize;
			PBlob = pBlob;
			PKeyInfoId = pKeyInfoId;
			PrivateDataSize = privateDataSize;
			PPrivateData = pPrivateData;
		}


	}

}
