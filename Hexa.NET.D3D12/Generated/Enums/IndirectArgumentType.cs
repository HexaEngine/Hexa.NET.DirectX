// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D12
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Flags]
	public enum IndirectArgumentType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		Draw = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		DrawIndexed = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		Dispatch = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		VertexBufferView = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		IndexBufferView = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		Constant = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		ConstantBufferView = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		ShaderResourceView = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		UnorderedAccessView = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		DispatchRays = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		DispatchMesh = unchecked(10),
	}
}