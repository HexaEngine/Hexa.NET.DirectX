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
	[Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6")]
	[NativeName(NativeNameType.StructOrClass, "ID3D11InfoQueue")]
	public partial struct ID3D11InfoQueue : IComObject, IComObject<ID3D11InfoQueue>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("6543dbb6-1b48-42f5-ab82-e97ec74326f6");

		public unsafe ID3D11InfoQueue (void** lpVtbl = null)
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
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetMessageCountLimit")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetMessageCountLimit([NativeName(NativeNameType.Param, "MessageCountLimit")] [NativeName(NativeNameType.Type, "UINT64")] ulong messageCountLimit) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, int>)(LpVtbl[3]))(ptr, messageCountLimit);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ClearStoredMessages")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void ClearStoredMessages() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)(LpVtbl[4]))(ptr);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMessageA")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetMessageA([NativeName(NativeNameType.Param, "MessageIndex")] [NativeName(NativeNameType.Type, "UINT64")] ulong messageIndex, [NativeName(NativeNameType.Param, "pMessage")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE*")] D3D11Message* pMessage, [NativeName(NativeNameType.Param, "pMessageByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] nuint* pMessageByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, D3D11Message*, nuint*, int>)(LpVtbl[5]))(ptr, messageIndex, pMessage, pMessageByteLength);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMessageA")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetMessageA([NativeName(NativeNameType.Param, "MessageIndex")] [NativeName(NativeNameType.Type, "UINT64")] ulong messageIndex, [NativeName(NativeNameType.Param, "pMessage")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE*")] ref D3D11Message pMessage, [NativeName(NativeNameType.Param, "pMessageByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] nuint* pMessageByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11Message* ppMessage = &pMessage)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, D3D11Message*, nuint*, int>)(LpVtbl[5]))(ptr, messageIndex, (D3D11Message*)ppMessage, pMessageByteLength);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMessageA")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetMessageA([NativeName(NativeNameType.Param, "MessageIndex")] [NativeName(NativeNameType.Type, "UINT64")] ulong messageIndex, [NativeName(NativeNameType.Param, "pMessage")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE*")] D3D11Message* pMessage, [NativeName(NativeNameType.Param, "pMessageByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] ref nuint pMessageByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (nuint* ppMessageByteLength = &pMessageByteLength)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, D3D11Message*, nuint*, int>)(LpVtbl[5]))(ptr, messageIndex, pMessage, (nuint*)ppMessageByteLength);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMessageA")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetMessageA([NativeName(NativeNameType.Param, "MessageIndex")] [NativeName(NativeNameType.Type, "UINT64")] ulong messageIndex, [NativeName(NativeNameType.Param, "pMessage")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE*")] ref D3D11Message pMessage, [NativeName(NativeNameType.Param, "pMessageByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] ref nuint pMessageByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11Message* ppMessage = &pMessage)
			{
				fixed (nuint* ppMessageByteLength = &pMessageByteLength)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, D3D11Message*, nuint*, int>)(LpVtbl[5]))(ptr, messageIndex, (D3D11Message*)ppMessage, (nuint*)ppMessageByteLength);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetNumMessagesAllowedByStorageFilter")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetNumMessagesAllowedByStorageFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)(LpVtbl[6]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetNumMessagesDeniedByStorageFilter")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetNumMessagesDeniedByStorageFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)(LpVtbl[7]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetNumStoredMessages")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetNumStoredMessages() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)(LpVtbl[8]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetNumStoredMessagesAllowedByRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetNumStoredMessagesAllowedByRetrievalFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)(LpVtbl[9]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetNumMessagesDiscardedByMessageCountLimit")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetNumMessagesDiscardedByMessageCountLimit() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)(LpVtbl[10]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMessageCountLimit")]
		[return: NativeName(NativeNameType.Type, "UINT64")]
		public readonly unsafe ulong GetMessageCountLimit() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ulong ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)(LpVtbl[11]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddStorageFilterEntries")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddStorageFilterEntries([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[12]))(ptr, pFilter);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddStorageFilterEntries")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddStorageFilterEntries([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[12]))(ptr, (D3D11InfoQueueFilter*)ppFilter);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetStorageFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] nuint* pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[13]))(ptr, pFilter, pFilterByteLength);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetStorageFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] nuint* pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[13]))(ptr, (D3D11InfoQueueFilter*)ppFilter, pFilterByteLength);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetStorageFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] ref nuint pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (nuint* ppFilterByteLength = &pFilterByteLength)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[13]))(ptr, pFilter, (nuint*)ppFilterByteLength);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetStorageFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] ref nuint pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				fixed (nuint* ppFilterByteLength = &pFilterByteLength)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[13]))(ptr, (D3D11InfoQueueFilter*)ppFilter, (nuint*)ppFilterByteLength);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ClearStorageFilter")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void ClearStorageFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)(LpVtbl[14]))(ptr);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushEmptyStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushEmptyStorageFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)(LpVtbl[15]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushCopyOfStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushCopyOfStorageFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)(LpVtbl[16]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushStorageFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[17]))(ptr, pFilter);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushStorageFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushStorageFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[17]))(ptr, (D3D11InfoQueueFilter*)ppFilter);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PopStorageFilter")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void PopStorageFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)(LpVtbl[18]))(ptr);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetStorageFilterStackSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetStorageFilterStackSize() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)(LpVtbl[19]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddRetrievalFilterEntries")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddRetrievalFilterEntries([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[20]))(ptr, pFilter);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddRetrievalFilterEntries")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddRetrievalFilterEntries([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[20]))(ptr, (D3D11InfoQueueFilter*)ppFilter);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetRetrievalFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] nuint* pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[21]))(ptr, pFilter, pFilterByteLength);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetRetrievalFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] nuint* pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[21]))(ptr, (D3D11InfoQueueFilter*)ppFilter, pFilterByteLength);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetRetrievalFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] ref nuint pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (nuint* ppFilterByteLength = &pFilterByteLength)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[21]))(ptr, pFilter, (nuint*)ppFilterByteLength);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int GetRetrievalFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter, [NativeName(NativeNameType.Param, "pFilterByteLength")] [NativeName(NativeNameType.Type, "SIZE_T*")] ref nuint pFilterByteLength) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				fixed (nuint* ppFilterByteLength = &pFilterByteLength)
				{
					int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, nuint*, int>)(LpVtbl[21]))(ptr, (D3D11InfoQueueFilter*)ppFilter, (nuint*)ppFilterByteLength);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ClearRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void ClearRetrievalFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)(LpVtbl[22]))(ptr);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushEmptyRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushEmptyRetrievalFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)(LpVtbl[23]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushCopyOfRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushCopyOfRetrievalFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)(LpVtbl[24]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushRetrievalFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] D3D11InfoQueueFilter* pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[25]))(ptr, pFilter);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PushRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int PushRetrievalFilter([NativeName(NativeNameType.Param, "pFilter")] [NativeName(NativeNameType.Type, "D3D11_INFO_QUEUE_FILTER*")] ref D3D11InfoQueueFilter pFilter) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (D3D11InfoQueueFilter* ppFilter = &pFilter)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11InfoQueueFilter*, int>)(LpVtbl[25]))(ptr, (D3D11InfoQueueFilter*)ppFilter);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "PopRetrievalFilter")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void PopRetrievalFilter() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)(LpVtbl[26]))(ptr);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetRetrievalFilterStackSize")]
		[return: NativeName(NativeNameType.Type, "UINT")]
		public readonly unsafe uint GetRetrievalFilterStackSize() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)(LpVtbl[27]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddMessage")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddMessage([NativeName(NativeNameType.Param, "Category")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_CATEGORY")] D3D11MessageCategory category, [NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "ID")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_ID")] D3D11MessageId id, [NativeName(NativeNameType.Param, "pDescription")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pDescription) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageCategory, D3D11MessageSeverity, D3D11MessageId, byte*, int>)(LpVtbl[28]))(ptr, category, severity, id, pDescription);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddMessage")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddMessage([NativeName(NativeNameType.Param, "Category")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_CATEGORY")] D3D11MessageCategory category, [NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "ID")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_ID")] D3D11MessageId id, [NativeName(NativeNameType.Param, "pDescription")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pDescription) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppDescription = pDescription)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageCategory, D3D11MessageSeverity, D3D11MessageId, byte*, int>)(LpVtbl[28]))(ptr, category, severity, id, (byte*)ppDescription);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddMessage")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddMessage([NativeName(NativeNameType.Param, "Category")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_CATEGORY")] D3D11MessageCategory category, [NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "ID")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_ID")] D3D11MessageId id, [NativeName(NativeNameType.Param, "pDescription")] [NativeName(NativeNameType.Type, "LPCSTR")] string pDescription) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pDescription != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pDescription);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pDescription, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageCategory, D3D11MessageSeverity, D3D11MessageId, byte*, int>)(LpVtbl[28]))(ptr, category, severity, id, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddApplicationMessage")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddApplicationMessage([NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "pDescription")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pDescription) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageSeverity, byte*, int>)(LpVtbl[29]))(ptr, severity, pDescription);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddApplicationMessage")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddApplicationMessage([NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "pDescription")] [NativeName(NativeNameType.Type, "LPCSTR")] ReadOnlySpan<byte> pDescription) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (byte* ppDescription = pDescription)
			{
				int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageSeverity, byte*, int>)(LpVtbl[29]))(ptr, severity, (byte*)ppDescription);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "AddApplicationMessage")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AddApplicationMessage([NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "pDescription")] [NativeName(NativeNameType.Type, "LPCSTR")] string pDescription) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pDescription != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pDescription);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pDescription, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageSeverity, byte*, int>)(LpVtbl[29]))(ptr, severity, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetBreakOnCategory")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetBreakOnCategory([NativeName(NativeNameType.Param, "Category")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_CATEGORY")] D3D11MessageCategory category, [NativeName(NativeNameType.Param, "bEnable")] [NativeName(NativeNameType.Type, "BOOL")] int bEnable) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageCategory, int, int>)(LpVtbl[30]))(ptr, category, bEnable);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetBreakOnSeverity")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetBreakOnSeverity([NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity, [NativeName(NativeNameType.Param, "bEnable")] [NativeName(NativeNameType.Type, "BOOL")] int bEnable) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageSeverity, int, int>)(LpVtbl[31]))(ptr, severity, bEnable);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetBreakOnID")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int SetBreakOnID([NativeName(NativeNameType.Param, "ID")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_ID")] D3D11MessageId id, [NativeName(NativeNameType.Param, "bEnable")] [NativeName(NativeNameType.Type, "BOOL")] int bEnable) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageId, int, int>)(LpVtbl[32]))(ptr, id, bEnable);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetBreakOnCategory")]
		[return: NativeName(NativeNameType.Type, "BOOL")]
		public readonly unsafe int GetBreakOnCategory([NativeName(NativeNameType.Param, "Category")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_CATEGORY")] D3D11MessageCategory category) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageCategory, int>)(LpVtbl[33]))(ptr, category);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetBreakOnSeverity")]
		[return: NativeName(NativeNameType.Type, "BOOL")]
		public readonly unsafe int GetBreakOnSeverity([NativeName(NativeNameType.Param, "Severity")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_SEVERITY")] D3D11MessageSeverity severity) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageSeverity, int>)(LpVtbl[34]))(ptr, severity);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetBreakOnID")]
		[return: NativeName(NativeNameType.Type, "BOOL")]
		public readonly unsafe int GetBreakOnID([NativeName(NativeNameType.Param, "ID")] [NativeName(NativeNameType.Type, "D3D11_MESSAGE_ID")] D3D11MessageId id) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, D3D11MessageId, int>)(LpVtbl[35]))(ptr, id);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetMuteDebugOutput")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void SetMuteDebugOutput([NativeName(NativeNameType.Param, "bMute")] [NativeName(NativeNameType.Type, "BOOL")] int bMute) 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int, void>)(LpVtbl[36]))(ptr, bMute);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "GetMuteDebugOutput")]
		[return: NativeName(NativeNameType.Type, "BOOL")]
		public readonly unsafe int GetMuteDebugOutput() 
		{
			ID3D11InfoQueue* ptr = (ID3D11InfoQueue*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)(LpVtbl[37]))(ptr);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D11InfoQueue value)
		{
			return Unsafe.As<ID3D11InfoQueue, IUnknown>(ref value);
		}

	}

}