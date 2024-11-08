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
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FeatureDataVideoExtensionCommandParameters
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public Guid CommandId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public VideoExtensionCommandParameterStage Stage;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ParameterCount;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VideoExtensionCommandParameterInfo* PParameterInfos;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe FeatureDataVideoExtensionCommandParameters(Guid commandId = default, VideoExtensionCommandParameterStage stage = default, uint parameterCount = default, VideoExtensionCommandParameterInfo* pParameterInfos = default)
		{
			CommandId = commandId;
			Stage = stage;
			ParameterCount = parameterCount;
			PParameterInfos = pParameterInfos;
		}


	}

}
