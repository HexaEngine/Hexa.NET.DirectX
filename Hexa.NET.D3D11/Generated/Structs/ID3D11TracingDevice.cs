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
	[Guid("1911c771-1587-413e-a7e0-fb26c3de0268")]
	public partial struct ID3D11TracingDevice : IComObject, IComObject<ID3D11TracingDevice>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("1911c771-1587-413e-a7e0-fb26c3de0268");

		public unsafe ID3D11TracingDevice (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetShaderTrackingOptionsByType(uint resourceTypeFlags, uint options) 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, uint, uint, HResult>)(LpVtbl[3]))(ptr, resourceTypeFlags, options);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetShaderTrackingOptions(IUnknown* pShader, uint options) 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, IUnknown*, uint, HResult>)(LpVtbl[4]))(ptr, pShader, options);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetShaderTrackingOptions(ref IUnknown pShader, uint options) 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppShader = &pShader)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, IUnknown*, uint, HResult>)(LpVtbl[4]))(ptr, (IUnknown*)ppShader, options);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetShaderTrackingOptions(ComPtr<IUnknown> pShader, uint options) 
		{
			ID3D11TracingDevice* ptr = (ID3D11TracingDevice*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D11TracingDevice*, IUnknown*, uint, HResult>)(LpVtbl[4]))(ptr, (IUnknown*)pShader.Handle, options);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D11TracingDevice value)
		{
			return Unsafe.As<ID3D11TracingDevice, IUnknown>(ref value);
		}

	}

}
