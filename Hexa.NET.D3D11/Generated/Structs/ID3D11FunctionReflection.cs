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
	/// {207BCECB-D683-4A06-A8A3-9B149B9F73A4}<br/>
	/// </summary>
	[Guid("207bcecb-d683-4a06-a8a3-9b149b9f73a4")]
	public partial struct ID3D11FunctionReflection : IComObject, IComObject<ID3D11FunctionReflection>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("207bcecb-d683-4a06-a8a3-9b149b9f73a4");

		public unsafe ID3D11FunctionReflection (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc(FunctionDesc* pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, HResult>)(*LpVtbl))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc(ref FunctionDesc pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (FunctionDesc* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, HResult>)(*LpVtbl))(ptr, (FunctionDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint bufferIndex) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D11ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)(LpVtbl[1]))(ptr, bufferIndex);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* name) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D11ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)(LpVtbl[2]))(ptr, name);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(ReadOnlySpan<byte> name) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				ID3D11ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)(LpVtbl[2]))(ptr, (byte*)pname);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(string name) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ID3D11ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)(LpVtbl[2]))(ptr, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDesc(uint resourceIndex, ShaderInputBindDesc* pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, HResult>)(LpVtbl[3]))(ptr, resourceIndex, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDesc(uint resourceIndex, ref ShaderInputBindDesc pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderInputBindDesc* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, HResult>)(LpVtbl[3]))(ptr, resourceIndex, (ShaderInputBindDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(byte* name) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D11ShaderReflectionVariable* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)(LpVtbl[4]))(ptr, name);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(ReadOnlySpan<byte> name) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				ID3D11ShaderReflectionVariable* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)(LpVtbl[4]))(ptr, (byte*)pname);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(string name) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			ID3D11ShaderReflectionVariable* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)(LpVtbl[4]))(ptr, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDescByName(byte* name, ShaderInputBindDesc* pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, HResult>)(LpVtbl[5]))(ptr, name, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDescByName(ReadOnlySpan<byte> name, ShaderInputBindDesc* pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, HResult>)(LpVtbl[5]))(ptr, (byte*)pname, pDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDescByName(string name, ShaderInputBindDesc* pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, HResult>)(LpVtbl[5]))(ptr, pStr0, pDesc);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDescByName(byte* name, ref ShaderInputBindDesc pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderInputBindDesc* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, HResult>)(LpVtbl[5]))(ptr, name, (ShaderInputBindDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDescByName(ReadOnlySpan<byte> name, ref ShaderInputBindDesc pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				fixed (ShaderInputBindDesc* ppDesc = &pDesc)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, HResult>)(LpVtbl[5]))(ptr, (byte*)pname, (ShaderInputBindDesc*)ppDesc);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetResourceBindingDescByName(string name, ref ShaderInputBindDesc pDesc) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			fixed (ShaderInputBindDesc* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, HResult>)(LpVtbl[5]))(ptr, pStr0, (ShaderInputBindDesc*)ppDesc);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe ID3D11FunctionParameterReflection* GetFunctionParameter(int parameterIndex) 
		{
			ID3D11FunctionReflection* ptr = (ID3D11FunctionReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D11FunctionParameterReflection* ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)(LpVtbl[6]))(ptr, parameterIndex);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

	}

}
