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
	[Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f")]
	[NativeName(NativeNameType.StructOrClass, "ID3D12SwapChainAssistant")]
	public partial struct ID3D12SwapChainAssistant : IComObject, IComObject<ID3D12SwapChainAssistant>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("f1df64b6-57fd-49cd-8807-c0eb88b45c8f");

		public unsafe ID3D12SwapChainAssistant (void** lpVtbl = null)
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
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetLUID")]
		[return: NativeName(NativeNameType.Type, "LUID")]
		public readonly unsafe Luid GetLUID() 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			Luid ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid>)(LpVtbl[3]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetSwapChainObject")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetSwapChainObject([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riid, [NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "void**")] void** ppv) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(LpVtbl[4]))(ptr, riid, ppv);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetSwapChainObject")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetSwapChainObject([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "void**")] void** ppv) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(LpVtbl[4]))(ptr, (Guid*)priid, ppv);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetSwapChainObject")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetSwapChainObject<T>([NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppv) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppv = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(LpVtbl[4]))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppv.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetSwapChainObject")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetSwapChainObject<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppv")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppv) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppv = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(LpVtbl[4]))(ptr, (Guid*)priid, (void**)ppv.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, riidResource, ppvResource, riidQueue, ppvQueue);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, ppvResource, riidQueue, ppvQueue);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<T>* pppvResource = &ppvResource)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)pppvResource, riidQueue, ppvQueue);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				fixed (ComPtr<T>* pppvResource = &ppvResource)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, (void**)pppvResource, riidQueue, ppvQueue);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidQueue = &riidQueue)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, riidResource, ppvResource, (Guid*)priidQueue, ppvQueue);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				fixed (Guid* priidQueue = &riidQueue)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, ppvResource, (Guid*)priidQueue, ppvQueue);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<T>* pppvResource = &ppvResource)
			{
				fixed (Guid* priidQueue = &riidQueue)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)pppvResource, (Guid*)priidQueue, ppvQueue);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] void** ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				fixed (ComPtr<T>* pppvResource = &ppvResource)
				{
					fixed (Guid* priidQueue = &riidQueue)
					{
						int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, (void**)pppvResource, (Guid*)priidQueue, ppvQueue);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvQueue = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, riidResource, ppvResource, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvQueue.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				ppvQueue = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, ppvResource, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvQueue.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T, T1>([NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T1> ppvQueue) where T : unmanaged, IComObject, IComObject<T> where T1 : unmanaged, IComObject, IComObject<T1>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<T>* pppvResource = &ppvResource)
			{
				ppvQueue = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)pppvResource, (Guid*)(ComUtils.GuidPtrOf<T1>()), (void**)ppvQueue.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T, T1>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T1> ppvQueue) where T : unmanaged, IComObject, IComObject<T> where T1 : unmanaged, IComObject, IComObject<T1>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				fixed (ComPtr<T>* pppvResource = &ppvResource)
				{
					ppvQueue = default;
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, (void**)pppvResource, (Guid*)(ComUtils.GuidPtrOf<T1>()), (void**)ppvQueue.GetAddressOf());
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] Guid* riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidQueue = &riidQueue)
			{
				ppvQueue = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, riidResource, ppvResource, (Guid*)priidQueue, (void**)ppvQueue.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] void** ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvQueue) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				fixed (Guid* priidQueue = &riidQueue)
				{
					ppvQueue = default;
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, ppvResource, (Guid*)priidQueue, (void**)ppvQueue.GetAddressOf());
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T, T1>([NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T1> ppvQueue) where T : unmanaged, IComObject, IComObject<T> where T1 : unmanaged, IComObject, IComObject<T1>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<T>* pppvResource = &ppvResource)
			{
				fixed (Guid* priidQueue = &riidQueue)
				{
					ppvQueue = default;
					int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)pppvResource, (Guid*)priidQueue, (void**)ppvQueue.GetAddressOf());
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetCurrentResourceAndCommandQueue")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetCurrentResourceAndCommandQueue<T, T1>([NativeName(NativeNameType.Param, "riidResource")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidResource, [NativeName(NativeNameType.Param, "ppvResource")] [NativeName(NativeNameType.Type, "void**")] ref ComPtr<T> ppvResource, [NativeName(NativeNameType.Param, "riidQueue")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riidQueue, [NativeName(NativeNameType.Param, "ppvQueue")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T1> ppvQueue) where T : unmanaged, IComObject, IComObject<T> where T1 : unmanaged, IComObject, IComObject<T1>
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priidResource = &riidResource)
			{
				fixed (ComPtr<T>* pppvResource = &ppvResource)
				{
					fixed (Guid* priidQueue = &riidQueue)
					{
						ppvQueue = default;
						int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(LpVtbl[5]))(ptr, (Guid*)priidResource, (void**)pppvResource, (Guid*)priidQueue, (void**)ppvQueue.GetAddressOf());
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "InsertImplicitSync")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int InsertImplicitSync() 
		{
			ID3D12SwapChainAssistant* ptr = (ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)(LpVtbl[6]))(ptr);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D12SwapChainAssistant value)
		{
			return Unsafe.As<ID3D12SwapChainAssistant, IUnknown>(ref value);
		}

	}

}