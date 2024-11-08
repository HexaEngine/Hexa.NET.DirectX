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
	public partial struct VideoDecoderOutputViewDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		public partial struct VideoDecoderOutputViewDescUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public Tex2DVdov Texture2D;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe VideoDecoderOutputViewDescUnion(Tex2DVdov texture2D = default)
			{
				Texture2D = texture2D;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public Guid DecodeProfile;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VdovDimension ViewDimension;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoDecoderOutputViewDescUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoDecoderOutputViewDesc(Guid decodeProfile = default, VdovDimension viewDimension = default, VideoDecoderOutputViewDescUnion union = default)
		{
			DecodeProfile = decodeProfile;
			ViewDimension = viewDimension;
			Union = union;
		}


	}

}
