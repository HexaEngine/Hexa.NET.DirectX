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
	[NativeName(NativeNameType.StructOrClass, "_D3D11_SIGNATURE_PARAMETER_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D11SignatureParameterDesc
	{
		/// <summary>
		/// Name of the semantic<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SemanticName")]
		[NativeName(NativeNameType.Type, "LPCSTR")]
		public unsafe byte* SemanticName;

		/// <summary>
		/// Index of the semantic<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SemanticIndex")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint SemanticIndex;

		/// <summary>
		/// Number of member variables<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Register")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Register;

		/// <summary>
		/// A predefined system value, or D3D_NAME_UNDEFINED if not applicable<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "SystemValueType")]
		[NativeName(NativeNameType.Type, "D3D_NAME")]
		public D3DName SystemValueType;

		/// <summary>
		/// Scalar type (e.g. uint, float, etc.)<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ComponentType")]
		[NativeName(NativeNameType.Type, "D3D_REGISTER_COMPONENT_TYPE")]
		public D3DRegisterComponentType ComponentType;

		/// <summary>
		/// Mask to indicate which components of the register<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Mask")]
		[NativeName(NativeNameType.Type, "BYTE")]
		public byte Mask;

		/// <summary>
		/// Mask to indicate whether a given component is<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "ReadWriteMask")]
		[NativeName(NativeNameType.Type, "BYTE")]
		public byte ReadWriteMask;

		/// <summary>
		/// Stream index<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "Stream")]
		[NativeName(NativeNameType.Type, "UINT")]
		public uint Stream;

		/// <summary>
		/// Minimum desired interpolation precision<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "MinPrecision")]
		[NativeName(NativeNameType.Type, "D3D_MIN_PRECISION")]
		public D3DMinPrecision MinPrecision;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D11SignatureParameterDesc(byte* semanticName = default, uint semanticIndex = default, uint register = default, D3DName systemValueType = default, D3DRegisterComponentType componentType = default, byte mask = default, byte readWriteMask = default, uint stream = default, D3DMinPrecision minPrecision = default)
		{
			SemanticName = semanticName;
			SemanticIndex = semanticIndex;
			Register = register;
			SystemValueType = systemValueType;
			ComponentType = componentType;
			Mask = mask;
			ReadWriteMask = readWriteMask;
			Stream = stream;
			MinPrecision = minPrecision;
		}


	}

}