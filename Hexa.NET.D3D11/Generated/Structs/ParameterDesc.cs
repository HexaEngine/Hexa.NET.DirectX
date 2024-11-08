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
	public partial struct ParameterDesc
	{
		/// <summary>
		/// Parameter name.<br/>
		/// </summary>
		public unsafe byte* Name;

		/// <summary>
		/// Parameter semantic name (+index).<br/>
		/// </summary>
		public unsafe byte* SemanticName;

		/// <summary>
		/// Element type.<br/>
		/// </summary>
		public ShaderVariableType Type;

		/// <summary>
		/// Scalar/Vector/Matrix.<br/>
		/// </summary>
		public ShaderVariableClass Class;

		/// <summary>
		/// Rows are for matrix parameters.<br/>
		/// </summary>
		public uint Rows;

		/// <summary>
		/// Components or Columns in matrix.<br/>
		/// </summary>
		public uint Columns;

		/// <summary>
		/// Interpolation mode.<br/>
		/// </summary>
		public InterpolationMode InterpolationMode;

		/// <summary>
		/// Parameter modifiers.<br/>
		/// </summary>
		public ParameterFlags Flags;

		/// <summary>
		/// The first input register for this parameter.<br/>
		/// </summary>
		public uint FirstInRegister;

		/// <summary>
		/// The first input register component for this parameter.<br/>
		/// </summary>
		public uint FirstInComponent;

		/// <summary>
		/// The first output register for this parameter.<br/>
		/// </summary>
		public uint FirstOutRegister;

		/// <summary>
		/// The first output register component for this parameter.<br/>
		/// </summary>
		public uint FirstOutComponent;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ParameterDesc(byte* name = default, byte* semanticName = default, ShaderVariableType type = default, ShaderVariableClass @class = default, uint rows = default, uint columns = default, InterpolationMode interpolationMode = default, ParameterFlags flags = default, uint firstInRegister = default, uint firstInComponent = default, uint firstOutRegister = default, uint firstOutComponent = default)
		{
			Name = name;
			SemanticName = semanticName;
			Type = type;
			Class = @class;
			Rows = rows;
			Columns = columns;
			InterpolationMode = interpolationMode;
			Flags = flags;
			FirstInRegister = firstInRegister;
			FirstInComponent = firstInComponent;
			FirstOutRegister = firstOutRegister;
			FirstOutComponent = firstOutComponent;
		}


	}

}
