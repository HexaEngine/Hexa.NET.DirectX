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
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3DCommon
{
	/// <summary>
	/// interface __MIDL_itf_d3dcommon_0000_0001 <br/>
	/// [local] <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D10BLOB")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct Lpd3D10Blob : IEquatable<Lpd3D10Blob>
	{
		public Lpd3D10Blob(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static Lpd3D10Blob Null => new Lpd3D10Blob(0);
		public static implicit operator Lpd3D10Blob(nint handle) => new Lpd3D10Blob(handle);
		public static bool operator ==(Lpd3D10Blob left, Lpd3D10Blob right) => left.Handle == right.Handle;
		public static bool operator !=(Lpd3D10Blob left, Lpd3D10Blob right) => left.Handle != right.Handle;
		public static bool operator ==(Lpd3D10Blob left, nint right) => left.Handle == right;
		public static bool operator !=(Lpd3D10Blob left, nint right) => left.Handle != right;
		public bool Equals(Lpd3D10Blob other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is Lpd3D10Blob handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("Lpd3D10Blob [0x{0}]", Handle.ToString("X"));
		#endif
	}
}