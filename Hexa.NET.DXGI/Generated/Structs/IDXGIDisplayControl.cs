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
	[Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c")]
	[NativeName(NativeNameType.StructOrClass, "IDXGIDisplayControl")]
	public partial struct IDXGIDisplayControl : IComObject, IComObject<IDXGIDisplayControl>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("ea9dbf1a-c88e-4486-854a-98aa0138f30c");

		public unsafe IDXGIDisplayControl (void** lpVtbl = null)
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
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "IsStereoEnabled")]
		[return: NativeName(NativeNameType.Type, "BOOL")]
		public readonly unsafe int IsStereoEnabled() 
		{
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, int>)(LpVtbl[3]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "SetStereoEnabled")]
		[return: NativeName(NativeNameType.Type, "void")]
		public readonly unsafe void SetStereoEnabled([NativeName(NativeNameType.Param, "enabled")] [NativeName(NativeNameType.Type, "BOOL")] int enabled) 
		{
			IDXGIDisplayControl* ptr = (IDXGIDisplayControl*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, int, void>)(LpVtbl[4]))(ptr, enabled);
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (IDXGIDisplayControl value)
		{
			return Unsafe.As<IDXGIDisplayControl, IUnknown>(ref value);
		}

	}

}