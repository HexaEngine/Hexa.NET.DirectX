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
	public partial struct RenderPassBeginningAccess
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		public partial struct RenderPassBeginningAccessUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[FieldOffset(0)]
			public RenderPassBeginningAccessClearParameters Clear;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe RenderPassBeginningAccessUnion(RenderPassBeginningAccessClearParameters clear = default)
			{
				Clear = clear;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public RenderPassBeginningAccessType Type;

		/// <summary>
		/// To be documented.
		/// </summary>
		public RenderPassBeginningAccessUnion Union;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe RenderPassBeginningAccess(RenderPassBeginningAccessType type = default, RenderPassBeginningAccessUnion union = default)
		{
			Type = type;
			Union = union;
		}


	}

}
