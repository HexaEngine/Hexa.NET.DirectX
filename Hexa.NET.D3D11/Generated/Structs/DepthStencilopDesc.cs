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
	public partial struct DepthStencilopDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public StencilOp StencilFailOp;

		/// <summary>
		/// To be documented.
		/// </summary>
		public StencilOp StencilDepthFailOp;

		/// <summary>
		/// To be documented.
		/// </summary>
		public StencilOp StencilPassOp;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ComparisonFunc StencilFunc;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe DepthStencilopDesc(StencilOp stencilFailOp = default, StencilOp stencilDepthFailOp = default, StencilOp stencilPassOp = default, ComparisonFunc stencilFunc = default)
		{
			StencilFailOp = stencilFailOp;
			StencilDepthFailOp = stencilDepthFailOp;
			StencilPassOp = stencilPassOp;
			StencilFunc = stencilFunc;
		}


	}

}
