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
	[Guid("cb7490ac-8a0f-44ec-9b7b-6f4cafe8e9ab")]
	[NativeName(NativeNameType.StructOrClass, "DirectMLTensorFlowCreatorID")]
	public partial struct DirectMLTensorFlowCreatorID : IComObject, IComObject<DirectMLTensorFlowCreatorID>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("cb7490ac-8a0f-44ec-9b7b-6f4cafe8e9ab");

		public unsafe DirectMLTensorFlowCreatorID (void** lpVtbl = null)
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
			DirectMLTensorFlowCreatorID* ptr = (DirectMLTensorFlowCreatorID*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<DirectMLTensorFlowCreatorID*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			DirectMLTensorFlowCreatorID* ptr = (DirectMLTensorFlowCreatorID*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<DirectMLTensorFlowCreatorID*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			DirectMLTensorFlowCreatorID* ptr = (DirectMLTensorFlowCreatorID*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<DirectMLTensorFlowCreatorID*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			DirectMLTensorFlowCreatorID* ptr = (DirectMLTensorFlowCreatorID*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<DirectMLTensorFlowCreatorID*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			DirectMLTensorFlowCreatorID* ptr = (DirectMLTensorFlowCreatorID*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<DirectMLTensorFlowCreatorID*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			DirectMLTensorFlowCreatorID* ptr = (DirectMLTensorFlowCreatorID*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<DirectMLTensorFlowCreatorID*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (DirectMLTensorFlowCreatorID value)
		{
			return Unsafe.As<DirectMLTensorFlowCreatorID, IUnknown>(ref value);
		}

	}

}