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
	[Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720")]
	[NativeName(NativeNameType.StructOrClass, "ID3D11CryptoSession")]
	public partial struct ID3D11CryptoSession : IComObject, IComObject<ID3D11CryptoSession>, IComObject<ID3D11DeviceChild>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("9b32f9ad-bdcc-40a6-a39d-d5c865845720");

		public unsafe ID3D11CryptoSession (void** lpVtbl = null)
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
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDevice")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetDevice([NativeName(NativeNameType.Param, "ppDevice")] [NativeName(NativeNameType.Type, "ID3D11Device**")] ID3D11Device** ppDevice) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, ID3D11Device**, void>)(LpVtbl[3]))(ptr, ppDevice);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDevice")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetDevice([NativeName(NativeNameType.Param, "ppDevice")] [NativeName(NativeNameType.Type, "ID3D11Device**")] ref ID3D11Device* ppDevice) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ID3D11Device** pppDevice = &ppDevice)
			{
				((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, ID3D11Device**, void>)(LpVtbl[3]))(ptr, (ID3D11Device**)pppDevice);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDevice")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetDevice([NativeName(NativeNameType.Param, "ppDevice")] [NativeName(NativeNameType.Type, "ID3D11Device**")] out ComPtr<ID3D11Device> ppDevice) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppDevice = default;
			((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, ID3D11Device**, void>)(LpVtbl[3]))(ptr, (ID3D11Device**)ppDevice.GetAddressOf());
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] uint* pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] void* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, guid, pDataSize, pData);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] uint* pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] void* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, (Guid*)pguid, pDataSize, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] void* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppDataSize = &pDataSize)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, guid, (uint*)ppDataSize, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] void* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				fixed (uint* ppDataSize = &pDataSize)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, (Guid*)pguid, (uint*)ppDataSize, pData);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData<T>([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] uint* pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, guid, pDataSize, (void*)pData.Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData<T>([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] uint* pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, (Guid*)pguid, pDataSize, (void*)pData.Handle);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData<T>([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppDataSize = &pDataSize)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, guid, (uint*)ppDataSize, (void*)pData.Handle);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetPrivateData<T>([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pDataSize")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pDataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] ComPtr<T> pData) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				fixed (uint* ppDataSize = &pDataSize)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint*, void*, int>)(LpVtbl[4]))(ptr, (Guid*)pguid, (uint*)ppDataSize, (void*)pData.Handle);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateData([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "DataSize")] [NativeName(NativeNameType.Type, "UINT")] uint dataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const void*")] void* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)(LpVtbl[5]))(ptr, guid, dataSize, pData);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateData")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateData([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "DataSize")] [NativeName(NativeNameType.Type, "UINT")] uint dataSize, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const void*")] void* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, uint, void*, int>)(LpVtbl[5]))(ptr, (Guid*)pguid, dataSize, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateDataInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateDataInterface([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const IUnknown*")] IUnknown* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(LpVtbl[6]))(ptr, guid, pData);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateDataInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateDataInterface([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const IUnknown*")] IUnknown* pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(LpVtbl[6]))(ptr, (Guid*)pguid, pData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateDataInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateDataInterface([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const IUnknown*")] ref IUnknown pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IUnknown* ppData = &pData)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(LpVtbl[6]))(ptr, guid, (IUnknown*)ppData);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateDataInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateDataInterface([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] Guid* guid, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const IUnknown*")] ComPtr<IUnknown> pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(LpVtbl[6]))(ptr, guid, (IUnknown*)pData.Handle);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateDataInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateDataInterface([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const IUnknown*")] ref IUnknown pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				fixed (IUnknown* ppData = &pData)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(LpVtbl[6]))(ptr, (Guid*)pguid, (IUnknown*)ppData);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetPrivateDataInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetPrivateDataInterface([NativeName(NativeNameType.Param, "guid")] [NativeName(NativeNameType.Type, "const GUID&")] ref Guid guid, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "const IUnknown*")] ComPtr<IUnknown> pData) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* pguid = &guid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, IUnknown*, int>)(LpVtbl[6]))(ptr, (Guid*)pguid, (IUnknown*)pData.Handle);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCryptoType")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetCryptoType([NativeName(NativeNameType.Param, "pCryptoType")] [NativeName(NativeNameType.Type, "GUID*")] Guid* pCryptoType) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)(LpVtbl[7]))(ptr, pCryptoType);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCryptoType")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetCryptoType([NativeName(NativeNameType.Param, "pCryptoType")] [NativeName(NativeNameType.Type, "GUID*")] ref Guid pCryptoType) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* ppCryptoType = &pCryptoType)
			{
				((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)(LpVtbl[7]))(ptr, (Guid*)ppCryptoType);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDecoderProfile")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetDecoderProfile([NativeName(NativeNameType.Param, "pDecoderProfile")] [NativeName(NativeNameType.Type, "GUID*")] Guid* pDecoderProfile) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)(LpVtbl[8]))(ptr, pDecoderProfile);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetDecoderProfile")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetDecoderProfile([NativeName(NativeNameType.Param, "pDecoderProfile")] [NativeName(NativeNameType.Type, "GUID*")] ref Guid pDecoderProfile) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* ppDecoderProfile = &pDecoderProfile)
			{
				((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, Guid*, void>)(LpVtbl[8]))(ptr, (Guid*)ppDecoderProfile);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCertificateSize")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCertificateSize([NativeName(NativeNameType.Param, "pCertificateSize")] [NativeName(NativeNameType.Type, "UINT*")] uint* pCertificateSize) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint*, int>)(LpVtbl[9]))(ptr, pCertificateSize);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCertificateSize")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCertificateSize([NativeName(NativeNameType.Param, "pCertificateSize")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pCertificateSize) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppCertificateSize = &pCertificateSize)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint*, int>)(LpVtbl[9]))(ptr, (uint*)ppCertificateSize);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCertificate")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCertificate([NativeName(NativeNameType.Param, "CertificateSize")] [NativeName(NativeNameType.Type, "UINT")] uint certificateSize, [NativeName(NativeNameType.Param, "pCertificate")] [NativeName(NativeNameType.Type, "BYTE*")] byte* pCertificate) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint, byte*, int>)(LpVtbl[10]))(ptr, certificateSize, pCertificate);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCertificate")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCertificate([NativeName(NativeNameType.Param, "CertificateSize")] [NativeName(NativeNameType.Type, "UINT")] uint certificateSize, [NativeName(NativeNameType.Param, "pCertificate")] [NativeName(NativeNameType.Type, "BYTE*")] ref byte pCertificate) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppCertificate = &pCertificate)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, uint, byte*, int>)(LpVtbl[10]))(ptr, certificateSize, (byte*)ppCertificate);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCryptoSessionHandle")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetCryptoSessionHandle([NativeName(NativeNameType.Param, "pCryptoSessionHandle")] [NativeName(NativeNameType.Type, "HANDLE*")] nint* pCryptoSessionHandle) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, nint*, void>)(LpVtbl[11]))(ptr, pCryptoSessionHandle);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCryptoSessionHandle")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void GetCryptoSessionHandle([NativeName(NativeNameType.Param, "pCryptoSessionHandle")] [NativeName(NativeNameType.Type, "HANDLE*")] ref nint pCryptoSessionHandle) 
		{
			ID3D11CryptoSession* ptr = (ID3D11CryptoSession*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (nint* ppCryptoSessionHandle = &pCryptoSessionHandle)
			{
				((delegate* unmanaged[Stdcall]<ID3D11CryptoSession*, nint*, void>)(LpVtbl[11]))(ptr, (nint*)ppCryptoSessionHandle);
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator ID3D11DeviceChild (ID3D11CryptoSession value)
		{
			return Unsafe.As<ID3D11CryptoSession, ID3D11DeviceChild>(ref value);
		}

		public unsafe static implicit operator IUnknown (ID3D11CryptoSession value)
		{
			return Unsafe.As<ID3D11CryptoSession, IUnknown>(ref value);
		}

	}

}