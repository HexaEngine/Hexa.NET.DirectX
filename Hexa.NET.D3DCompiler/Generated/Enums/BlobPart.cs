// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using Hexa.NET.D3DCommon;
using Hexa.NET.D3D11;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3DCompiler
{
	/// <summary>
	/// ----------------------------------------------------------------------------<br/>
	/// D3DGetBlobPart:<br/>
	/// -----------------------<br/>
	/// Extracts information from a compilation result.<br/>
	/// ----------------------------------------------------------------------------<br/>
	/// </summary>
	[Flags]
	public enum BlobPart : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		InputSignatureBlob = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		OutputSignatureBlob = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		InputAndOutputSignatureBlob = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		PatchConstantSignatureBlob = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		AllSignatureBlob = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		DebugInfo = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		LegacyShader = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		XnaPrepassShader = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		XnaShader = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		Pdb = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		PrivateData = unchecked(10),

		/// <summary>
		/// To be documented.
		/// </summary>
		RootSignature = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		DebugName = unchecked(12),

		/// <summary>
		/// Test parts are only produced by special compiler versions and so<br/>
		/// are usually not present in shaders.<br/>
		/// </summary>
		TestAlternateShader = unchecked(32768),

		/// <summary>
		/// Test parts are only produced by special compiler versions and so<br/>
		/// are usually not present in shaders.<br/>
		/// </summary>
		TestCompileDetails = unchecked(32769),

		/// <summary>
		/// Test parts are only produced by special compiler versions and so<br/>
		/// are usually not present in shaders.<br/>
		/// </summary>
		TestCompilePerf = unchecked(32770),

		/// <summary>
		/// Test parts are only produced by special compiler versions and so<br/>
		/// are usually not present in shaders.<br/>
		/// </summary>
		TestCompileReport = unchecked(32771),
	}
}
