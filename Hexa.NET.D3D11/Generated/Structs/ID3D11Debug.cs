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
	[Guid("79cf2233-7536-4948-9d36-1e4692dc5760")]
	public partial struct ID3D11Debug : IComObject, IComObject<ID3D11Debug>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("79cf2233-7536-4948-9d36-1e4692dc5760");

		public unsafe ID3D11Debug (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetFeatureMask(uint mask) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, HResult>)(LpVtbl[3]))(ptr, mask);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint GetFeatureMask() 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(LpVtbl[4]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPresentPerRenderOpDelay(uint milliseconds) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, HResult>)(LpVtbl[5]))(ptr, milliseconds);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint GetPresentPerRenderOpDelay() 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)(LpVtbl[6]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetSwapChain(IDXGISwapChain* pSwapChain) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, IDXGISwapChain*, HResult>)(LpVtbl[7]))(ptr, pSwapChain);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetSwapChain(ref IDXGISwapChain pSwapChain) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDXGISwapChain* ppSwapChain = &pSwapChain)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, IDXGISwapChain*, HResult>)(LpVtbl[7]))(ptr, (IDXGISwapChain*)ppSwapChain);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetSwapChain(ComPtr<IDXGISwapChain> pSwapChain) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, IDXGISwapChain*, HResult>)(LpVtbl[7]))(ptr, (IDXGISwapChain*)pSwapChain.Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetSwapChain(IDXGISwapChain** ppSwapChain) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, IDXGISwapChain**, HResult>)(LpVtbl[8]))(ptr, ppSwapChain);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetSwapChain(ref IDXGISwapChain* ppSwapChain) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDXGISwapChain** pppSwapChain = &ppSwapChain)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, IDXGISwapChain**, HResult>)(LpVtbl[8]))(ptr, (IDXGISwapChain**)pppSwapChain);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetSwapChain(out ComPtr<IDXGISwapChain> ppSwapChain) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppSwapChain = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, IDXGISwapChain**, HResult>)(LpVtbl[8]))(ptr, (IDXGISwapChain**)ppSwapChain.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ValidateContext(ID3D11DeviceContext* pContext) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, HResult>)(LpVtbl[9]))(ptr, pContext);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ValidateContext(ref ID3D11DeviceContext pContext) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ID3D11DeviceContext* ppContext = &pContext)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, HResult>)(LpVtbl[9]))(ptr, (ID3D11DeviceContext*)ppContext);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ValidateContext(ComPtr<ID3D11DeviceContext> pContext) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, HResult>)(LpVtbl[9]))(ptr, (ID3D11DeviceContext*)pContext.Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ReportLiveDeviceObjects(RldoFlags flags) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, RldoFlags, HResult>)(LpVtbl[10]))(ptr, flags);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ValidateContextForDispatch(ID3D11DeviceContext* pContext) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, HResult>)(LpVtbl[11]))(ptr, pContext);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ValidateContextForDispatch(ref ID3D11DeviceContext pContext) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ID3D11DeviceContext* ppContext = &pContext)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, HResult>)(LpVtbl[11]))(ptr, (ID3D11DeviceContext*)ppContext);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult ValidateContextForDispatch(ComPtr<ID3D11DeviceContext> pContext) 
		{
			ID3D11Debug* ptr = (ID3D11Debug*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, HResult>)(LpVtbl[11]))(ptr, (ID3D11DeviceContext*)pContext.Handle);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D11Debug value)
		{
			return Unsafe.As<ID3D11Debug, IUnknown>(ref value);
		}

	}

}
