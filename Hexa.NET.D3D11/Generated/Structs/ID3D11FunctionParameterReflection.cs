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
	/// {42757488-334F-47FE-982E-1A65D08CC462}<br/>
	/// </summary>
	[Guid("42757488-334f-47fe-982e-1a65d08cc462")]
	[NativeName(NativeNameType.StructOrClass, "ID3D11FunctionParameterReflection")]
	public partial struct ID3D11FunctionParameterReflection : IComObject, IComObject<ID3D11FunctionParameterReflection>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("42757488-334f-47fe-982e-1a65d08cc462");

		public unsafe ID3D11FunctionParameterReflection (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetDesc([NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D11_PARAMETER_DESC*")] D3D11ParameterDesc* pDesc) 
		{
			ID3D11FunctionParameterReflection* ptr = (ID3D11FunctionParameterReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionParameterReflection*, D3D11ParameterDesc*, int>)(*LpVtbl))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetDesc([NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D11_PARAMETER_DESC*")] ref D3D11ParameterDesc pDesc) 
		{
			ID3D11FunctionParameterReflection* ptr = (ID3D11FunctionParameterReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11ParameterDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionParameterReflection*, D3D11ParameterDesc*, int>)(*LpVtbl))(ptr, (D3D11ParameterDesc*)ppDesc);
				return ret;
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

	}

}