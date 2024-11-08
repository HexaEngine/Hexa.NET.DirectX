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
	public partial struct ID3D11ShaderTraceFactory : IComObject, IComObject<ID3D11ShaderTraceFactory>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public unsafe ID3D11ShaderTraceFactory (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, pShader, pTraceDesc, ppShaderTrace);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ref IUnknown pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppShader = &pShader)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)ppShader, pTraceDesc, ppShaderTrace);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ComPtr<IUnknown> pShader, ShaderTraceDesc* pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)pShader.Handle, pTraceDesc, ppShaderTrace);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, pShader, (ShaderTraceDesc*)ppTraceDesc, ppShaderTrace);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ref IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppShader = &pShader)
			{
				fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)ppShader, (ShaderTraceDesc*)ppTraceDesc, ppShaderTrace);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ComPtr<IUnknown> pShader, ref ShaderTraceDesc pTraceDesc, ID3D11ShaderTrace** ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)pShader.Handle, (ShaderTraceDesc*)ppTraceDesc, ppShaderTrace);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(IUnknown* pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ID3D11ShaderTrace** pppShaderTrace = &ppShaderTrace)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, pShader, pTraceDesc, (ID3D11ShaderTrace**)pppShaderTrace);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(IUnknown* pShader, ShaderTraceDesc* pTraceDesc, out ComPtr<ID3D11ShaderTrace> ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppShaderTrace = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, pShader, pTraceDesc, (ID3D11ShaderTrace**)ppShaderTrace.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ref IUnknown pShader, ShaderTraceDesc* pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppShader = &pShader)
			{
				fixed (ID3D11ShaderTrace** pppShaderTrace = &ppShaderTrace)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)ppShader, pTraceDesc, (ID3D11ShaderTrace**)pppShaderTrace);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ComPtr<IUnknown> pShader, ShaderTraceDesc* pTraceDesc, out ComPtr<ID3D11ShaderTrace> ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppShaderTrace = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)pShader.Handle, pTraceDesc, (ID3D11ShaderTrace**)ppShaderTrace.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
			{
				fixed (ID3D11ShaderTrace** pppShaderTrace = &ppShaderTrace)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, pShader, (ShaderTraceDesc*)ppTraceDesc, (ID3D11ShaderTrace**)pppShaderTrace);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(IUnknown* pShader, ref ShaderTraceDesc pTraceDesc, out ComPtr<ID3D11ShaderTrace> ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
			{
				ppShaderTrace = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, pShader, (ShaderTraceDesc*)ppTraceDesc, (ID3D11ShaderTrace**)ppShaderTrace.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ref IUnknown pShader, ref ShaderTraceDesc pTraceDesc, ref ID3D11ShaderTrace* ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppShader = &pShader)
			{
				fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
				{
					fixed (ID3D11ShaderTrace** pppShaderTrace = &ppShaderTrace)
					{
						HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)ppShader, (ShaderTraceDesc*)ppTraceDesc, (ID3D11ShaderTrace**)pppShaderTrace);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateShaderTrace(ComPtr<IUnknown> pShader, ref ShaderTraceDesc pTraceDesc, out ComPtr<ID3D11ShaderTrace> ppShaderTrace) 
		{
			ID3D11ShaderTraceFactory* ptr = (ID3D11ShaderTraceFactory*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ShaderTraceDesc* ppTraceDesc = &pTraceDesc)
			{
				ppShaderTrace = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderTraceFactory*, IUnknown*, ShaderTraceDesc*, ID3D11ShaderTrace**, HResult>)(LpVtbl[3]))(ptr, (IUnknown*)pShader.Handle, (ShaderTraceDesc*)ppTraceDesc, (ID3D11ShaderTrace**)ppShaderTrace.GetAddressOf());
				return ret;
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D11ShaderTraceFactory value)
		{
			return Unsafe.As<ID3D11ShaderTraceFactory, IUnknown>(ref value);
		}

	}

}
