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
	/// To be documented.
	/// </summary>
	[Guid("98931d33-5ae8-4791-aa3c-1a73a2934e71")]
	public partial struct ID3D12DeviceRemovedExtendedData : IComObject, IComObject<ID3D12DeviceRemovedExtendedData>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("98931d33-5ae8-4791-aa3c-1a73a2934e71");

		public unsafe ID3D12DeviceRemovedExtendedData (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAutoBreadcrumbsOutput(DredAutoBreadcrumbsOutput* pOutput) 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredAutoBreadcrumbsOutput*, HResult>)(LpVtbl[3]))(ptr, pOutput);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAutoBreadcrumbsOutput(ref DredAutoBreadcrumbsOutput pOutput) 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (DredAutoBreadcrumbsOutput* ppOutput = &pOutput)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredAutoBreadcrumbsOutput*, HResult>)(LpVtbl[3]))(ptr, (DredAutoBreadcrumbsOutput*)ppOutput);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPageFaultAllocationOutput(DredPageFaultOutput* pOutput) 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredPageFaultOutput*, HResult>)(LpVtbl[4]))(ptr, pOutput);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPageFaultAllocationOutput(ref DredPageFaultOutput pOutput) 
		{
			ID3D12DeviceRemovedExtendedData* ptr = (ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (DredPageFaultOutput* ppOutput = &pOutput)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredPageFaultOutput*, HResult>)(LpVtbl[4]))(ptr, (DredPageFaultOutput*)ppOutput);
				return ret;
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D12DeviceRemovedExtendedData value)
		{
			return Unsafe.As<ID3D12DeviceRemovedExtendedData, IUnknown>(ref value);
		}

	}

}
