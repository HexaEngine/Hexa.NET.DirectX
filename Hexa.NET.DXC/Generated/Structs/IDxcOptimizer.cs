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
	public partial struct IDxcOptimizer : IComObject, IComObject<IDxcOptimizer>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public unsafe IDxcOptimizer (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(Guid* riid, void** ppvObject) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, HResult>)(*LpVtbl))(ptr, riid, ppvObject);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface(ref Guid riid, void** ppvObject) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, ppvObject);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult QueryInterface<T>(ref Guid riid, out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* priid = &riid)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)priid, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint AddRef() 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe uint Release() 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAvailablePassCount(uint* pCount) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, HResult>)(LpVtbl[3]))(ptr, pCount);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAvailablePassCount(ref uint pCount) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppCount = &pCount)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, HResult>)(LpVtbl[3]))(ptr, (uint*)ppCount);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAvailablePass(uint index, IDxcOptimizerPass** ppResult) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, HResult>)(LpVtbl[4]))(ptr, index, ppResult);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAvailablePass(uint index, ref IDxcOptimizerPass* ppResult) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcOptimizerPass** pppResult = &ppResult)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, HResult>)(LpVtbl[4]))(ptr, index, (IDxcOptimizerPass**)pppResult);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult GetAvailablePass(uint index, out ComPtr<IDxcOptimizerPass> ppResult) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppResult = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, HResult>)(LpVtbl[4]))(ptr, index, (IDxcOptimizerPass**)ppResult.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, ppOptions, optionCount, pOutputModule, ppOutputText);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, pOutputModule, ppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (char** pppOptions = &ppOptions)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, (char**)pppOptions, optionCount, pOutputModule, ppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, (char**)pppOptions, optionCount, pOutputModule, ppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob** ppOutputModule = &pOutputModule)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (IDxcBlob** ppOutputModule = &pOutputModule)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, char** ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (IDxcBlob** ppOutputModule = &pOutputModule)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (char** pppOptions = &ppOptions)
				{
					fixed (IDxcBlob** ppOutputModule = &pOutputModule)
					{
						HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, IDxcBlobEncoding** ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, ppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)pppOutputText);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppOutputText = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, ppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)pppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppOutputText = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, ppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)pppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				ppOutputText = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (char** pppOptions = &ppOptions)
				{
					fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
					{
						HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, (char**)pppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)pppOutputText);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				ppOutputText = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, (char**)pppOptions, optionCount, pOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob** ppOutputModule = &pOutputModule)
			{
				fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)pppOutputText);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
			{
				ppOutputText = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (IDxcBlob** ppOutputModule = &pOutputModule)
				{
					fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
					{
						HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)pppOutputText);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, char** ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
			{
				ppOutputText = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, ppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (IDxcBlob** ppOutputModule = &pOutputModule)
				{
					fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
					{
						HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)pppOutputText);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
				{
					ppOutputText = default;
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, pBlob, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (IDxcBlob* ppBlob = &pBlob)
			{
				fixed (char** pppOptions = &ppOptions)
				{
					fixed (IDxcBlob** ppOutputModule = &pOutputModule)
					{
						fixed (IDxcBlobEncoding** pppOutputText = &ppOutputText)
						{
							HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)ppBlob, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)pppOutputText);
							return ret;
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public readonly unsafe HResult RunOptimizer(ComPtr<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, ref ComPtr<IDxcBlob> pOutputModule, out ComPtr<IDxcBlobEncoding> ppOutputText) 
		{
			IDxcOptimizer* ptr = (IDxcOptimizer*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (char** pppOptions = &ppOptions)
			{
				fixed (ComPtr<IDxcBlob>* ppOutputModule = &pOutputModule)
				{
					ppOutputText = default;
					HResult ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, HResult>)(LpVtbl[5]))(ptr, (IDxcBlob*)pBlob.Handle, (char**)pppOptions, optionCount, (IDxcBlob**)ppOutputModule, (IDxcBlobEncoding**)ppOutputText.GetAddressOf());
					return ret;
				}
			}
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (IDxcOptimizer value)
		{
			return Unsafe.As<IDxcOptimizer, IUnknown>(ref value);
		}

	}

}
