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
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3DINCLUDE")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct Lpd3Dinclude : IEquatable<Lpd3Dinclude>
	{
		public Lpd3Dinclude(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static Lpd3Dinclude Null => new Lpd3Dinclude(0);
		public static implicit operator Lpd3Dinclude(nint handle) => new Lpd3Dinclude(handle);
		public static bool operator ==(Lpd3Dinclude left, Lpd3Dinclude right) => left.Handle == right.Handle;
		public static bool operator !=(Lpd3Dinclude left, Lpd3Dinclude right) => left.Handle != right.Handle;
		public static bool operator ==(Lpd3Dinclude left, nint right) => left.Handle == right;
		public static bool operator !=(Lpd3Dinclude left, nint right) => left.Handle != right;
		public bool Equals(Lpd3Dinclude other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is Lpd3Dinclude handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("Lpd3Dinclude [0x{0}]", Handle.ToString("X"));
		#endif
	}
}