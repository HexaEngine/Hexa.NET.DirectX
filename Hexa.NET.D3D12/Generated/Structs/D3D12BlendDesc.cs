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
	[NativeName(NativeNameType.StructOrClass, "D3D12_BLEND_DESC")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct D3D12BlendDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AlphaToCoverageEnable")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int AlphaToCoverageEnable;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "IndependentBlendEnable")]
		[NativeName(NativeNameType.Type, "BOOL")]
		public int IndependentBlendEnable;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "RenderTarget")]
		[NativeName(NativeNameType.Type, "D3D12_RENDER_TARGET_BLEND_DESC[8]")]
		public D3D12RenderTargetBlendDesc RenderTarget_0;
		public D3D12RenderTargetBlendDesc RenderTarget_1;
		public D3D12RenderTargetBlendDesc RenderTarget_2;
		public D3D12RenderTargetBlendDesc RenderTarget_3;
		public D3D12RenderTargetBlendDesc RenderTarget_4;
		public D3D12RenderTargetBlendDesc RenderTarget_5;
		public D3D12RenderTargetBlendDesc RenderTarget_6;
		public D3D12RenderTargetBlendDesc RenderTarget_7;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12BlendDesc(int alphaToCoverageEnable = default, int independentBlendEnable = default, D3D12RenderTargetBlendDesc* renderTarget = default)
		{
			AlphaToCoverageEnable = alphaToCoverageEnable;
			IndependentBlendEnable = independentBlendEnable;
			if (renderTarget != default(D3D12RenderTargetBlendDesc*))
			{
				RenderTarget_0 = renderTarget[0];
				RenderTarget_1 = renderTarget[1];
				RenderTarget_2 = renderTarget[2];
				RenderTarget_3 = renderTarget[3];
				RenderTarget_4 = renderTarget[4];
				RenderTarget_5 = renderTarget[5];
				RenderTarget_6 = renderTarget[6];
				RenderTarget_7 = renderTarget[7];
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe D3D12BlendDesc(int alphaToCoverageEnable = default, int independentBlendEnable = default, Span<D3D12RenderTargetBlendDesc> renderTarget = default)
		{
			AlphaToCoverageEnable = alphaToCoverageEnable;
			IndependentBlendEnable = independentBlendEnable;
			if (renderTarget != default(Span<D3D12RenderTargetBlendDesc>))
			{
				RenderTarget_0 = renderTarget[0];
				RenderTarget_1 = renderTarget[1];
				RenderTarget_2 = renderTarget[2];
				RenderTarget_3 = renderTarget[3];
				RenderTarget_4 = renderTarget[4];
				RenderTarget_5 = renderTarget[5];
				RenderTarget_6 = renderTarget[6];
				RenderTarget_7 = renderTarget[7];
			}
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<D3D12RenderTargetBlendDesc> RenderTarget
		
		{
			get
			{
				fixed (D3D12RenderTargetBlendDesc* p = &this.RenderTarget_0)
				{
					return new Span<D3D12RenderTargetBlendDesc>(p, 8);
				}
			}
		}
	}

}