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
	/// {5A58797D-A72C-478D-8BA2-EFC6B0EFE88E}<br/>
	/// </summary>
	[Guid("5a58797d-a72c-478d-8ba2-efc6b0efe88e")]
	[NativeName(NativeNameType.StructOrClass, "ID3D12ShaderReflection")]
	public partial struct ID3D12ShaderReflection : IComObject, IComObject<ID3D12ShaderReflection>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("5a58797d-a72c-478d-8ba2-efc6b0efe88e");

		public unsafe ID3D12ShaderReflection (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddRef")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint AddRef() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "iid")] [NativeName(NativeNameType.Type, "const IID&")] Guid* iid, [NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "LPVOID*")] ref void* ppv) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (void** pppv = &ppv)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)(LpVtbl[3]))(ptr, iid, (void**)pppv);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "iid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid iid, [NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "LPVOID*")] ref void* ppv) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* piid = &iid)
			{
				fixed (void** pppv = &ppv)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, Guid*, void**, int>)(LpVtbl[3]))(ptr, (Guid*)piid, (void**)pppv);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetDesc([NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_DESC*")] D3D12ShaderDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, D3D12ShaderDesc*, int>)(LpVtbl[4]))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetDesc([NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_DESC*")] ref D3D12ShaderDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D12ShaderDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, D3D12ShaderDesc*, int>)(LpVtbl[4]))(ptr, (D3D12ShaderDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetConstantBufferByIndex")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionConstantBuffer*")]
		public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeName(NativeNameType.Param, "Index")] [NativeName(NativeNameType.Type, "UINT")] uint index) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D12ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)(LpVtbl[5]))(ptr, index);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetConstantBufferByName")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionConstantBuffer*")]
		public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* name) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D12ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)(LpVtbl[6]))(ptr, name);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetConstantBufferByName")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionConstantBuffer*")]
		public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> name) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				ID3D12ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)(LpVtbl[6]))(ptr, (byte*)pname);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetConstantBufferByName")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionConstantBuffer*")]
		public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] string name) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
			ID3D12ShaderReflectionConstantBuffer* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)(LpVtbl[6]))(ptr, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDesc([NativeName(NativeNameType.Param, "ResourceIndex")] [NativeName(NativeNameType.Type, "UINT")] uint resourceIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] D3D12ShaderInputBindDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12ShaderInputBindDesc*, int>)(LpVtbl[7]))(ptr, resourceIndex, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDesc([NativeName(NativeNameType.Param, "ResourceIndex")] [NativeName(NativeNameType.Type, "UINT")] uint resourceIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] ref D3D12ShaderInputBindDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D12ShaderInputBindDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12ShaderInputBindDesc*, int>)(LpVtbl[7]))(ptr, resourceIndex, (D3D12ShaderInputBindDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetInputParameterDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetInputParameterDesc([NativeName(NativeNameType.Param, "ParameterIndex")] [NativeName(NativeNameType.Type, "UINT")] uint parameterIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SIGNATURE_PARAMETER_DESC*")] D3D12SignatureParameterDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12SignatureParameterDesc*, int>)(LpVtbl[8]))(ptr, parameterIndex, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetInputParameterDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetInputParameterDesc([NativeName(NativeNameType.Param, "ParameterIndex")] [NativeName(NativeNameType.Type, "UINT")] uint parameterIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SIGNATURE_PARAMETER_DESC*")] ref D3D12SignatureParameterDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D12SignatureParameterDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12SignatureParameterDesc*, int>)(LpVtbl[8]))(ptr, parameterIndex, (D3D12SignatureParameterDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetOutputParameterDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetOutputParameterDesc([NativeName(NativeNameType.Param, "ParameterIndex")] [NativeName(NativeNameType.Type, "UINT")] uint parameterIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SIGNATURE_PARAMETER_DESC*")] D3D12SignatureParameterDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12SignatureParameterDesc*, int>)(LpVtbl[9]))(ptr, parameterIndex, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetOutputParameterDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetOutputParameterDesc([NativeName(NativeNameType.Param, "ParameterIndex")] [NativeName(NativeNameType.Type, "UINT")] uint parameterIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SIGNATURE_PARAMETER_DESC*")] ref D3D12SignatureParameterDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D12SignatureParameterDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12SignatureParameterDesc*, int>)(LpVtbl[9]))(ptr, parameterIndex, (D3D12SignatureParameterDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPatchConstantParameterDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPatchConstantParameterDesc([NativeName(NativeNameType.Param, "ParameterIndex")] [NativeName(NativeNameType.Type, "UINT")] uint parameterIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SIGNATURE_PARAMETER_DESC*")] D3D12SignatureParameterDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12SignatureParameterDesc*, int>)(LpVtbl[10]))(ptr, parameterIndex, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPatchConstantParameterDesc")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPatchConstantParameterDesc([NativeName(NativeNameType.Param, "ParameterIndex")] [NativeName(NativeNameType.Type, "UINT")] uint parameterIndex, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SIGNATURE_PARAMETER_DESC*")] ref D3D12SignatureParameterDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D12SignatureParameterDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint, D3D12SignatureParameterDesc*, int>)(LpVtbl[10]))(ptr, parameterIndex, (D3D12SignatureParameterDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetVariableByName")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionVariable*")]
		public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* name) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ID3D12ShaderReflectionVariable* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)(LpVtbl[11]))(ptr, name);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetVariableByName")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionVariable*")]
		public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> name) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				ID3D12ShaderReflectionVariable* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)(LpVtbl[11]))(ptr, (byte*)pname);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetVariableByName")]
		[return: NativeName(NativeNameType.Type, "ID3D12ShaderReflectionVariable*")]
		public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] string name) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
			ID3D12ShaderReflectionVariable* ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, ID3D12ShaderReflectionVariable*>)(LpVtbl[11]))(ptr, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDescByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDescByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* name, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] D3D12ShaderInputBindDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, D3D12ShaderInputBindDesc*, int>)(LpVtbl[12]))(ptr, name, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDescByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDescByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> name, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] D3D12ShaderInputBindDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, D3D12ShaderInputBindDesc*, int>)(LpVtbl[12]))(ptr, (byte*)pname, pDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDescByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDescByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] string name, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] D3D12ShaderInputBindDesc* pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, D3D12ShaderInputBindDesc*, int>)(LpVtbl[12]))(ptr, pStr0, pDesc);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDescByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDescByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* name, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] ref D3D12ShaderInputBindDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D12ShaderInputBindDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, D3D12ShaderInputBindDesc*, int>)(LpVtbl[12]))(ptr, name, (D3D12ShaderInputBindDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDescByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDescByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> name, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] ref D3D12ShaderInputBindDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* pname = name)
			{
				fixed (D3D12ShaderInputBindDesc* ppDesc = &pDesc)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, D3D12ShaderInputBindDesc*, int>)(LpVtbl[12]))(ptr, (byte*)pname, (D3D12ShaderInputBindDesc*)ppDesc);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetResourceBindingDescByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetResourceBindingDescByName([NativeName(NativeNameType.Param, "Name")] [NativeName(NativeNameType.Type, "LPCSTR")] string name, [NativeName(NativeNameType.Param, "pDesc")] [NativeName(NativeNameType.Type, "D3D12_SHADER_INPUT_BIND_DESC*")] ref D3D12ShaderInputBindDesc pDesc) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
			fixed (D3D12ShaderInputBindDesc* ppDesc = &pDesc)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, byte*, D3D12ShaderInputBindDesc*, int>)(LpVtbl[12]))(ptr, pStr0, (D3D12ShaderInputBindDesc*)ppDesc);
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
		[NativeName(NativeNameType.Func, "GetMovInstructionCount")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetMovInstructionCount() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[13]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMovcInstructionCount")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetMovcInstructionCount() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[14]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetConversionInstructionCount")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetConversionInstructionCount() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[15]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetBitwiseInstructionCount")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetBitwiseInstructionCount() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[16]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetGSInputPrimitive")]
		[return: NativeName(NativeNameType.Type, "D3D_PRIMITIVE")]
		public readonly unsafe D3DPrimitive GetGSInputPrimitive() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			D3DPrimitive ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, D3DPrimitive>)(LpVtbl[17]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "IsSampleFrequencyShader")]
		[return: NativeName(NativeNameType.Type, "BOOL")]
		public readonly unsafe int IsSampleFrequencyShader() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, int>)(LpVtbl[18]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetNumInterfaceSlots")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetNumInterfaceSlots() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint>)(LpVtbl[19]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMinFeatureLevel")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetMinFeatureLevel([NativeName(NativeNameType.Param, "pLevel")] [NativeName(NativeNameType.Type, "D3D_FEATURE_LEVEL*")] D3DFeatureLevel* pLevel) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, D3DFeatureLevel*, int>)(LpVtbl[20]))(ptr, pLevel);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMinFeatureLevel")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetMinFeatureLevel([NativeName(NativeNameType.Param, "pLevel")] [NativeName(NativeNameType.Type, "D3D_FEATURE_LEVEL*")] ref D3DFeatureLevel pLevel) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3DFeatureLevel* ppLevel = &pLevel)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, D3DFeatureLevel*, int>)(LpVtbl[20]))(ptr, (D3DFeatureLevel*)ppLevel);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, pSizeX, pSizeY, pSizeZ);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeX = &pSizeX)
			{
				uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, (uint*)ppSizeX, pSizeY, pSizeZ);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeY = &pSizeY)
			{
				uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, pSizeX, (uint*)ppSizeY, pSizeZ);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeX = &pSizeX)
			{
				fixed (uint* ppSizeY = &pSizeY)
				{
					uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, (uint*)ppSizeX, (uint*)ppSizeY, pSizeZ);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeZ = &pSizeZ)
			{
				uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, pSizeX, pSizeY, (uint*)ppSizeZ);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeX = &pSizeX)
			{
				fixed (uint* ppSizeZ = &pSizeZ)
				{
					uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, (uint*)ppSizeX, pSizeY, (uint*)ppSizeZ);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] uint* pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeY = &pSizeY)
			{
				fixed (uint* ppSizeZ = &pSizeZ)
				{
					uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, pSizeX, (uint*)ppSizeY, (uint*)ppSizeZ);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetThreadGroupSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetThreadGroupSize([NativeName(NativeNameType.Param, "pSizeX")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeX, [NativeName(NativeNameType.Param, "pSizeY")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeY, [NativeName(NativeNameType.Param, "pSizeZ")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pSizeZ) 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppSizeX = &pSizeX)
			{
				fixed (uint* ppSizeY = &pSizeY)
				{
					fixed (uint* ppSizeZ = &pSizeZ)
					{
						uint ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(LpVtbl[21]))(ptr, (uint*)ppSizeX, (uint*)ppSizeY, (uint*)ppSizeZ);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetRequiresFlags")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetRequiresFlags() 
		{
			ID3D12ShaderReflection* ptr = (ID3D12ShaderReflection*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflection*, ulong>)(LpVtbl[22]))(ptr);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D12ShaderReflection value)
		{
			return Unsafe.As<ID3D12ShaderReflection, IUnknown>(ref value);
		}

	}

}