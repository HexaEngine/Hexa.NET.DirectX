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
	public partial struct SubresourceTiling
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint WidthInTiles;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ushort HeightInTiles;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ushort DepthInTiles;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint StartTileIndexInOverallResource;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SubresourceTiling(uint widthInTiles = default, ushort heightInTiles = default, ushort depthInTiles = default, uint startTileIndexInOverallResource = default)
		{
			WidthInTiles = widthInTiles;
			HeightInTiles = heightInTiles;
			DepthInTiles = depthInTiles;
			StartTileIndexInOverallResource = startTileIndexInOverallResource;
		}


	}

}