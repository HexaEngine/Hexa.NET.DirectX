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
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3DCommon
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "_D3D_SHADER_INPUT_TYPE")]
	[Flags]
	public enum D3DShaderInputType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_CBUFFER")]
		[NativeName(NativeNameType.Value, "0")]
		SitCbuffer = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_TBUFFER")]
		[NativeName(NativeNameType.Value, "1")]
		SitTbuffer = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_TEXTURE")]
		[NativeName(NativeNameType.Value, "2")]
		SitTexture = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_SAMPLER")]
		[NativeName(NativeNameType.Value, "3")]
		SitSampler = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_RWTYPED")]
		[NativeName(NativeNameType.Value, "4")]
		SitUavRwtyped = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_STRUCTURED")]
		[NativeName(NativeNameType.Value, "5")]
		SitStructured = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_RWSTRUCTURED")]
		[NativeName(NativeNameType.Value, "6")]
		SitUavRwstructured = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_BYTEADDRESS")]
		[NativeName(NativeNameType.Value, "7")]
		SitByteaddress = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_RWBYTEADDRESS")]
		[NativeName(NativeNameType.Value, "8")]
		SitUavRwbyteaddress = unchecked(8),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_APPEND_STRUCTURED")]
		[NativeName(NativeNameType.Value, "9")]
		SitUavAppendStructured = unchecked(9),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_CONSUME_STRUCTURED")]
		[NativeName(NativeNameType.Value, "10")]
		SitUavConsumeStructured = unchecked(10),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER")]
		[NativeName(NativeNameType.Value, "11")]
		SitUavRwstructuredWithCounter = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_RTACCELERATIONSTRUCTURE")]
		[NativeName(NativeNameType.Value, "12")]
		SitRtaccelerationstructure = unchecked(12),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D_SIT_UAV_FEEDBACKTEXTURE")]
		[NativeName(NativeNameType.Value, "13")]
		SitUavFeedbacktexture = unchecked(13),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D10_SIT_CBUFFER")]
		[NativeName(NativeNameType.Value, "D3D_SIT_CBUFFER")]
		D10SitCbuffer = SitCbuffer,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D10_SIT_TBUFFER")]
		[NativeName(NativeNameType.Value, "D3D_SIT_TBUFFER")]
		D10SitTbuffer = SitTbuffer,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D10_SIT_TEXTURE")]
		[NativeName(NativeNameType.Value, "D3D_SIT_TEXTURE")]
		D10SitTexture = SitTexture,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D10_SIT_SAMPLER")]
		[NativeName(NativeNameType.Value, "D3D_SIT_SAMPLER")]
		D10SitSampler = SitSampler,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_UAV_RWTYPED")]
		[NativeName(NativeNameType.Value, "D3D_SIT_UAV_RWTYPED")]
		D11SitUavRwtyped = SitUavRwtyped,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_STRUCTURED")]
		[NativeName(NativeNameType.Value, "D3D_SIT_STRUCTURED")]
		D11SitStructured = SitStructured,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_UAV_RWSTRUCTURED")]
		[NativeName(NativeNameType.Value, "D3D_SIT_UAV_RWSTRUCTURED")]
		D11SitUavRwstructured = SitUavRwstructured,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_BYTEADDRESS")]
		[NativeName(NativeNameType.Value, "D3D_SIT_BYTEADDRESS")]
		D11SitByteaddress = SitByteaddress,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_UAV_RWBYTEADDRESS")]
		[NativeName(NativeNameType.Value, "D3D_SIT_UAV_RWBYTEADDRESS")]
		D11SitUavRwbyteaddress = SitUavRwbyteaddress,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_UAV_APPEND_STRUCTURED")]
		[NativeName(NativeNameType.Value, "D3D_SIT_UAV_APPEND_STRUCTURED")]
		D11SitUavAppendStructured = SitUavAppendStructured,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_UAV_CONSUME_STRUCTURED")]
		[NativeName(NativeNameType.Value, "D3D_SIT_UAV_CONSUME_STRUCTURED")]
		D11SitUavConsumeStructured = SitUavConsumeStructured,

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER")]
		[NativeName(NativeNameType.Value, "D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER")]
		D11SitUavRwstructuredWithCounter = SitUavRwstructuredWithCounter,
	}
}