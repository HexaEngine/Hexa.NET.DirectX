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
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXC
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "IDxcAssembler")]
	public partial struct IDxcAssembler : IComObject, IComObject<IDxcAssembler>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public unsafe IDxcAssembler (void** lpVtbl = null)
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
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
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
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid riid, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, Guid*, void**, int>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
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
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] IDxcBlob* pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] IDxcOperationResult** ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, pShader, ppResult);
			return ret;
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] ref IDxcBlob pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] IDxcOperationResult** ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppShader = &pShader)
			{
				int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, (IDxcBlob*)ppShader, ppResult);
				return ret;
			}
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] ComPtr<IDxcBlob> pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] IDxcOperationResult** ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, (IDxcBlob*)pShader.Handle, ppResult);
			return ret;
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] IDxcBlob* pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] ref IDxcOperationResult* ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcOperationResult** pppResult = &ppResult)
			{
				int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, pShader, (IDxcOperationResult**)pppResult);
				return ret;
			}
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] IDxcBlob* pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] out ComPtr<IDxcOperationResult> ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppResult = default;
			int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, pShader, (IDxcOperationResult**)ppResult.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] ref IDxcBlob pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] ref IDxcOperationResult* ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppShader = &pShader)
			{
				fixed (IDxcOperationResult** pppResult = &ppResult)
				{
					int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, (IDxcBlob*)ppShader, (IDxcOperationResult**)pppResult);
					return ret;
				}
			}
		}

		/// <summary>
		/// Assemble dxil in ll or llvm bitcode to DXIL container.<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "AssembleToContainer")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe int AssembleToContainer([NativeName(NativeNameType.Param, "pShader")] [NativeName(NativeNameType.Type, "IDxcBlob*")] ComPtr<IDxcBlob> pShader, [NativeName(NativeNameType.Param, "ppResult")] [NativeName(NativeNameType.Type, "IDxcOperationResult**")] out ComPtr<IDxcOperationResult> ppResult) 
		{
			IDxcAssembler* ptr = (IDxcAssembler*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppResult = default;
			int ret = ((delegate* unmanaged[Stdcall]<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(LpVtbl[3]))(ptr, (IDxcBlob*)pShader.Handle, (IDxcOperationResult**)ppResult.GetAddressOf());
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (IDxcAssembler value)
		{
			return Unsafe.As<IDxcAssembler, IUnknown>(ref value);
		}

	}

}