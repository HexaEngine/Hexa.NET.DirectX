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
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct LpD3D11Shaderreflectionconstantbuffer : IEquatable<LpD3D11Shaderreflectionconstantbuffer>
	{
		public LpD3D11Shaderreflectionconstantbuffer(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Shaderreflectionconstantbuffer Null => new LpD3D11Shaderreflectionconstantbuffer(0);
		public static implicit operator LpD3D11Shaderreflectionconstantbuffer(nint handle) => new LpD3D11Shaderreflectionconstantbuffer(handle);
		public static bool operator ==(LpD3D11Shaderreflectionconstantbuffer left, LpD3D11Shaderreflectionconstantbuffer right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Shaderreflectionconstantbuffer left, LpD3D11Shaderreflectionconstantbuffer right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Shaderreflectionconstantbuffer left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Shaderreflectionconstantbuffer left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Shaderreflectionconstantbuffer other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Shaderreflectionconstantbuffer handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("LpD3D11Shaderreflectionconstantbuffer [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
