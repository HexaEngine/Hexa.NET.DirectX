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
	/// {469E07F7-045A-48D5-AA12-68A478CDF75D}<br/>
	/// </summary>
	[Guid("469e07f7-045a-48d5-aa12-68a478cdf75d")]
	[NativeName(NativeNameType.StructOrClass, "ID3D11ModuleInstance")]
	public partial struct ID3D11ModuleInstance : IComObject, IComObject<ID3D11ModuleInstance>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("469e07f7-045a-48d5-aa12-68a478cdf75d");

		public unsafe ID3D11ModuleInstance (void** lpVtbl = null)
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
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "iid")] [NativeName(NativeNameType.Type, "const IID&")] Guid* iid, [NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "LPVOID*")] ref void* ppv) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (void** pppv = &ppv)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(LpVtbl[3]))(ptr, iid, (void**)pppv);
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
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* piid = &iid)
			{
				fixed (void** pppv = &ppv)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(LpVtbl[3]))(ptr, (Guid*)piid, (void**)pppv);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindConstantBuffer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindConstantBuffer([NativeName(NativeNameType.Param, "uSrcSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uSrcSlot, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "cbDstOffset")] [NativeName(NativeNameType.Type, "UINT")] uint cbDstOffset) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(LpVtbl[4]))(ptr, uSrcSlot, uDstSlot, cbDstOffset);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindConstantBufferByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindConstantBufferByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "cbDstOffset")] [NativeName(NativeNameType.Type, "UINT")] uint cbDstOffset) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[5]))(ptr, pName, uDstSlot, cbDstOffset);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindConstantBufferByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindConstantBufferByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "cbDstOffset")] [NativeName(NativeNameType.Type, "UINT")] uint cbDstOffset) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppName = pName)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[5]))(ptr, (byte*)ppName, uDstSlot, cbDstOffset);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindConstantBufferByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindConstantBufferByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] string pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "cbDstOffset")] [NativeName(NativeNameType.Type, "UINT")] uint cbDstOffset) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pName != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pName);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pName, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[5]))(ptr, pStr0, uDstSlot, cbDstOffset);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResource")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResource([NativeName(NativeNameType.Param, "uSrcSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uSrcSlot, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(LpVtbl[6]))(ptr, uSrcSlot, uDstSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[7]))(ptr, pName, uDstSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppName = pName)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[7]))(ptr, (byte*)ppName, uDstSlot, uCount);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] string pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pName != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pName);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pName, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[7]))(ptr, pStr0, uDstSlot, uCount);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindSampler")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindSampler([NativeName(NativeNameType.Param, "uSrcSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uSrcSlot, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(LpVtbl[8]))(ptr, uSrcSlot, uDstSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindSamplerByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindSamplerByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[9]))(ptr, pName, uDstSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindSamplerByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindSamplerByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppName = pName)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[9]))(ptr, (byte*)ppName, uDstSlot, uCount);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindSamplerByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindSamplerByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] string pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pName != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pName);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pName, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[9]))(ptr, pStr0, uDstSlot, uCount);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindUnorderedAccessView")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindUnorderedAccessView([NativeName(NativeNameType.Param, "uSrcSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uSrcSlot, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(LpVtbl[10]))(ptr, uSrcSlot, uDstSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindUnorderedAccessViewByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindUnorderedAccessViewByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[11]))(ptr, pName, uDstSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindUnorderedAccessViewByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindUnorderedAccessViewByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppName = pName)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[11]))(ptr, (byte*)ppName, uDstSlot, uCount);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindUnorderedAccessViewByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindUnorderedAccessViewByName([NativeName(NativeNameType.Param, "pName")] [NativeName(NativeNameType.Type, "LPCSTR")] string pName, [NativeName(NativeNameType.Param, "uDstSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pName != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pName);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pName, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[11]))(ptr, pStr0, uDstSlot, uCount);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceAsUnorderedAccessView")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceAsUnorderedAccessView([NativeName(NativeNameType.Param, "uSrcSrvSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uSrcSrvSlot, [NativeName(NativeNameType.Param, "uDstUavSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstUavSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(LpVtbl[12]))(ptr, uSrcSrvSlot, uDstUavSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceAsUnorderedAccessViewByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceAsUnorderedAccessViewByName([NativeName(NativeNameType.Param, "pSrvName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pSrvName, [NativeName(NativeNameType.Param, "uDstUavSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstUavSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[13]))(ptr, pSrvName, uDstUavSlot, uCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceAsUnorderedAccessViewByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceAsUnorderedAccessViewByName([NativeName(NativeNameType.Param, "pSrvName")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pSrvName, [NativeName(NativeNameType.Param, "uDstUavSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstUavSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppSrvName = pSrvName)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[13]))(ptr, (byte*)ppSrvName, uDstUavSlot, uCount);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "BindResourceAsUnorderedAccessViewByName")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int BindResourceAsUnorderedAccessViewByName([NativeName(NativeNameType.Param, "pSrvName")] [NativeName(NativeNameType.Type, "LPCSTR")] string pSrvName, [NativeName(NativeNameType.Param, "uDstUavSlot")] [NativeName(NativeNameType.Type, "UINT")] uint uDstUavSlot, [NativeName(NativeNameType.Param, "uCount")] [NativeName(NativeNameType.Type, "UINT")] uint uCount) 
		{
			ID3D11ModuleInstance* ptr = (ID3D11ModuleInstance*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pSrvName != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pSrvName);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pSrvName, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)(LpVtbl[13]))(ptr, pStr0, uDstUavSlot, uCount);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D11ModuleInstance value)
		{
			return Unsafe.As<ID3D11ModuleInstance, IUnknown>(ref value);
		}

	}

}