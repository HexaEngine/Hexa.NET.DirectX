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
	/// {CAC701EE-80FC-4122-8242-10B39C8CEC34}<br/>
	/// </summary>
	[Guid("cac701ee-80fc-4122-8242-10b39c8cec34")]
	public partial struct ID3D11Module : IComObject, IComObject<ID3D11Module>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("cac701ee-80fc-4122-8242-10b39c8cec34");

		public unsafe ID3D11Module (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* iid, ref void* ppv) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (void** pppv = &ppv)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, HResult>)(LpVtbl[3]))(ptr, iid, (void**)pppv);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid iid, ref void* ppv) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* piid = &iid)
			{
				fixed (void** pppv = &ppv)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, HResult>)(LpVtbl[3]))(ptr, (Guid*)piid, (void**)pppv);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(byte* pNamespace, ID3D11ModuleInstance** ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, pNamespace, ppModuleInstance);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(ReadOnlySpan<byte> pNamespace, ID3D11ModuleInstance** ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppNamespace = pNamespace)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, (byte*)ppNamespace, ppModuleInstance);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(string pNamespace, ID3D11ModuleInstance** ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pNamespace != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pNamespace);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pNamespace, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, pStr0, ppModuleInstance);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(byte* pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ID3D11ModuleInstance** pppModuleInstance = &ppModuleInstance)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, pNamespace, (ID3D11ModuleInstance**)pppModuleInstance);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(byte* pNamespace, out ComPtr<ID3D11ModuleInstance> ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppModuleInstance = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, pNamespace, (ID3D11ModuleInstance**)ppModuleInstance.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(ReadOnlySpan<byte> pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppNamespace = pNamespace)
			{
				fixed (ID3D11ModuleInstance** pppModuleInstance = &ppModuleInstance)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, (byte*)ppNamespace, (ID3D11ModuleInstance**)pppModuleInstance);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CreateInstance(string pNamespace, ref ID3D11ModuleInstance* ppModuleInstance) 
		{
			ID3D11Module* ptr = (ID3D11Module*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pNamespace != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pNamespace);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pNamespace, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			fixed (ID3D11ModuleInstance** pppModuleInstance = &ppModuleInstance)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Module*, byte*, ID3D11ModuleInstance**, HResult>)(LpVtbl[4]))(ptr, pStr0, (ID3D11ModuleInstance**)pppModuleInstance);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
				return ret;
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D11Module value)
		{
			return Unsafe.As<ID3D11Module, IUnknown>(ref value);
		}

	}

}
