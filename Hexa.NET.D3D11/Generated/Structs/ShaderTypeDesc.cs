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
	public partial struct ShaderTypeDesc
	{
		/// <summary>
		/// Variable class (e.g. object, matrix, etc.)<br/>
		/// </summary>
		public ShaderVariableClass Class;

		/// <summary>
		/// Variable type (e.g. float, sampler, etc.)<br/>
		/// </summary>
		public ShaderVariableType Type;

		/// <summary>
		/// Number of rows (for matrices, 1 for other numeric, 0 if not applicable)<br/>
		/// </summary>
		public uint Rows;

		/// <summary>
		/// Number of columns (for vectors <br/>
		/// &<br/>
		/// matrices, 1 for other numeric, 0 if not applicable)<br/>
		/// </summary>
		public uint Columns;

		/// <summary>
		/// Number of elements (0 if not an array)<br/>
		/// </summary>
		public uint Elements;

		/// <summary>
		/// Number of members (0 if not a structure)<br/>
		/// </summary>
		public uint Members;

		/// <summary>
		/// Offset from the start of structure (0 if not a structure member)<br/>
		/// </summary>
		public uint Offset;

		/// <summary>
		/// Name of type, can be NULL<br/>
		/// </summary>
		public unsafe byte* Name;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ShaderTypeDesc(ShaderVariableClass @class = default, ShaderVariableType type = default, uint rows = default, uint columns = default, uint elements = default, uint members = default, uint offset = default, byte* name = default)
		{
			Class = @class;
			Type = type;
			Rows = rows;
			Columns = columns;
			Elements = elements;
			Members = members;
			Offset = offset;
			Name = name;
		}


	}

}