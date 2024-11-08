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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[Guid("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e")]
	public partial struct IDXGIAdapter4 : IComObject, IComObject<IDXGIAdapter4>, IComObject<IDXGIAdapter3>, IComObject<IDXGIAdapter2>, IComObject<IDXGIAdapter1>, IComObject<IDXGIAdapter>, IComObject<IDXGIObject>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e");

		public unsafe IDXGIAdapter4 (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateData(Guid* name, uint dataSize, void* pData) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, HResult>)(LpVtbl[3]))(ptr, name, dataSize, pData);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateData(ref Guid name, uint dataSize, void* pData) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, HResult>)(LpVtbl[3]))(ptr, (Guid*)pname, dataSize, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateDataInterface(Guid* name, IUnknown* pUnknown) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, IUnknown*, HResult>)(LpVtbl[4]))(ptr, name, pUnknown);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateDataInterface(ref Guid name, IUnknown* pUnknown) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, IUnknown*, HResult>)(LpVtbl[4]))(ptr, (Guid*)pname, pUnknown);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateDataInterface(Guid* name, ref IUnknown pUnknown) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppUnknown = &pUnknown)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, IUnknown*, HResult>)(LpVtbl[4]))(ptr, name, (IUnknown*)ppUnknown);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateDataInterface(Guid* name, ComPtr<IUnknown> pUnknown) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, IUnknown*, HResult>)(LpVtbl[4]))(ptr, name, (IUnknown*)pUnknown.Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateDataInterface(ref Guid name, ref IUnknown pUnknown) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				fixed (IUnknown* ppUnknown = &pUnknown)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, IUnknown*, HResult>)(LpVtbl[4]))(ptr, (Guid*)pname, (IUnknown*)ppUnknown);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetPrivateDataInterface(ref Guid name, ComPtr<IUnknown> pUnknown) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, IUnknown*, HResult>)(LpVtbl[4]))(ptr, (Guid*)pname, (IUnknown*)pUnknown.Handle);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData(Guid* name, uint* pDataSize, void* pData) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, name, pDataSize, pData);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData(ref Guid name, uint* pDataSize, void* pData) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, (Guid*)pname, pDataSize, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData(Guid* name, ref uint pDataSize, void* pData) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppDataSize = &pDataSize)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, name, (uint*)ppDataSize, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData(ref Guid name, ref uint pDataSize, void* pData) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				fixed (uint* ppDataSize = &pDataSize)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, (Guid*)pname, (uint*)ppDataSize, pData);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData<T>(Guid* name, uint* pDataSize, ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, name, pDataSize, (void*)pData.Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData<T>(ref Guid name, uint* pDataSize, ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, (Guid*)pname, pDataSize, (void*)pData.Handle);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData<T>(Guid* name, ref uint pDataSize, ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppDataSize = &pDataSize)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, name, (uint*)ppDataSize, (void*)pData.Handle);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetPrivateData<T>(ref Guid name, ref uint pDataSize, ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pname = &name)
			{
				fixed (uint* ppDataSize = &pDataSize)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, HResult>)(LpVtbl[5]))(ptr, (Guid*)pname, (uint*)ppDataSize, (void*)pData.Handle);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetParent(Guid* riid, void** ppParent) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(LpVtbl[6]))(ptr, riid, ppParent);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetParent(ref Guid riid, void** ppParent) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(LpVtbl[6]))(ptr, (Guid*)priid, ppParent);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetParent<T>(out ComPtr<T> ppParent) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppParent = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(LpVtbl[6]))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppParent.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetParent<T>(ref Guid riid, out ComPtr<T> ppParent) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppParent = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, HResult>)(LpVtbl[6]))(ptr, (Guid*)priid, (void**)ppParent.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult EnumOutputs(uint output, IDXGIOutput** ppOutput) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, HResult>)(LpVtbl[7]))(ptr, output, ppOutput);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult EnumOutputs(uint output, ref IDXGIOutput* ppOutput) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDXGIOutput** pppOutput = &ppOutput)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, HResult>)(LpVtbl[7]))(ptr, output, (IDXGIOutput**)pppOutput);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult EnumOutputs(uint output, out ComPtr<IDXGIOutput> ppOutput) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppOutput = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, HResult>)(LpVtbl[7]))(ptr, output, (IDXGIOutput**)ppOutput.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc(AdapterDesc* pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc*, HResult>)(LpVtbl[8]))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc(ref AdapterDesc pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (AdapterDesc* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc*, HResult>)(LpVtbl[8]))(ptr, (AdapterDesc*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CheckInterfaceSupport(Guid* interfaceName, long* pUMDVersion) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, HResult>)(LpVtbl[9]))(ptr, interfaceName, pUMDVersion);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CheckInterfaceSupport(ref Guid interfaceName, long* pUMDVersion) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pinterfaceName = &interfaceName)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, HResult>)(LpVtbl[9]))(ptr, (Guid*)pinterfaceName, pUMDVersion);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CheckInterfaceSupport(Guid* interfaceName, ref long pUMDVersion) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (long* ppUMDVersion = &pUMDVersion)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, HResult>)(LpVtbl[9]))(ptr, interfaceName, (long*)ppUMDVersion);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult CheckInterfaceSupport(ref Guid interfaceName, ref long pUMDVersion) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pinterfaceName = &interfaceName)
			{
				fixed (long* ppUMDVersion = &pUMDVersion)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, HResult>)(LpVtbl[9]))(ptr, (Guid*)pinterfaceName, (long*)ppUMDVersion);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc1(AdapterDesc1* pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc1*, HResult>)(LpVtbl[10]))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc1(ref AdapterDesc1 pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (AdapterDesc1* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc1*, HResult>)(LpVtbl[10]))(ptr, (AdapterDesc1*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc2(AdapterDesc2* pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc2*, HResult>)(LpVtbl[11]))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc2(ref AdapterDesc2 pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (AdapterDesc2* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc2*, HResult>)(LpVtbl[11]))(ptr, (AdapterDesc2*)ppDesc);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RegisterHardwareContentProtectionTeardownStatusEvent(nint hEvent, uint* pdwCookie) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, nint, uint*, HResult>)(LpVtbl[12]))(ptr, hEvent, pdwCookie);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RegisterHardwareContentProtectionTeardownStatusEvent(nint hEvent, ref uint pdwCookie) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppdwCookie = &pdwCookie)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, nint, uint*, HResult>)(LpVtbl[12]))(ptr, hEvent, (uint*)ppdwCookie);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe void UnregisterHardwareContentProtectionTeardownStatus(uint dwCookie) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)(LpVtbl[13]))(ptr, dwCookie);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryVideoMemoryInfo(uint nodeIndex, MemorySegmentGroup memorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, HResult>)(LpVtbl[14]))(ptr, nodeIndex, memorySegmentGroup, pVideoMemoryInfo);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryVideoMemoryInfo(uint nodeIndex, MemorySegmentGroup memorySegmentGroup, ref QueryVideoMemoryInfo pVideoMemoryInfo) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (QueryVideoMemoryInfo* ppVideoMemoryInfo = &pVideoMemoryInfo)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, HResult>)(LpVtbl[14]))(ptr, nodeIndex, memorySegmentGroup, (QueryVideoMemoryInfo*)ppVideoMemoryInfo);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult SetVideoMemoryReservation(uint nodeIndex, MemorySegmentGroup memorySegmentGroup, ulong reservation) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, ulong, HResult>)(LpVtbl[15]))(ptr, nodeIndex, memorySegmentGroup, reservation);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RegisterVideoMemoryBudgetChangeNotificationEvent(nint hEvent, uint* pdwCookie) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, nint, uint*, HResult>)(LpVtbl[16]))(ptr, hEvent, pdwCookie);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RegisterVideoMemoryBudgetChangeNotificationEvent(nint hEvent, ref uint pdwCookie) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppdwCookie = &pdwCookie)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, nint, uint*, HResult>)(LpVtbl[16]))(ptr, hEvent, (uint*)ppdwCookie);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe void UnregisterVideoMemoryBudgetChangeNotification(uint dwCookie) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)(LpVtbl[17]))(ptr, dwCookie);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc3(AdapterDesc3* pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc3*, HResult>)(LpVtbl[18]))(ptr, pDesc);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetDesc3(ref AdapterDesc3 pDesc) 
		{
			IDXGIAdapter4* ptr = (IDXGIAdapter4*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (AdapterDesc3* ppDesc = &pDesc)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc3*, HResult>)(LpVtbl[18]))(ptr, (AdapterDesc3*)ppDesc);
				return ret;
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IDXGIAdapter3 (IDXGIAdapter4 value)
		{
			return Unsafe.As<IDXGIAdapter4, IDXGIAdapter3>(ref value);
		}

		public unsafe static implicit operator IDXGIAdapter2 (IDXGIAdapter4 value)
		{
			return Unsafe.As<IDXGIAdapter4, IDXGIAdapter2>(ref value);
		}

		public unsafe static implicit operator IDXGIAdapter1 (IDXGIAdapter4 value)
		{
			return Unsafe.As<IDXGIAdapter4, IDXGIAdapter1>(ref value);
		}

		public unsafe static implicit operator IDXGIAdapter (IDXGIAdapter4 value)
		{
			return Unsafe.As<IDXGIAdapter4, IDXGIAdapter>(ref value);
		}

		public unsafe static implicit operator IDXGIObject (IDXGIAdapter4 value)
		{
			return Unsafe.As<IDXGIAdapter4, IDXGIObject>(ref value);
		}

		public unsafe static implicit operator IUnknown (IDXGIAdapter4 value)
		{
			return Unsafe.As<IDXGIAdapter4, IUnknown>(ref value);
		}

	}

}
