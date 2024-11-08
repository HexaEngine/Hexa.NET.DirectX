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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SurfaceDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Width;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Height;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Format Format;

		/// <summary>
		/// To be documented.
		/// </summary>
		public SampleDesc SampleDesc;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SurfaceDesc(uint width = default, uint height = default, Format format = default, SampleDesc sampleDesc = default)
		{
			Width = width;
			Height = height;
			Format = format;
			SampleDesc = sampleDesc;
		}


	}

}
