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
	[NativeName(NativeNameType.Typedef, "LPD3DBLOB")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct Lpd3Dblob : IEquatable<Lpd3Dblob>
	{
		public Lpd3Dblob(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static Lpd3Dblob Null => new Lpd3Dblob(0);
		public static implicit operator Lpd3Dblob(nint handle) => new Lpd3Dblob(handle);
		public static bool operator ==(Lpd3Dblob left, Lpd3Dblob right) => left.Handle == right.Handle;
		public static bool operator !=(Lpd3Dblob left, Lpd3Dblob right) => left.Handle != right.Handle;
		public static bool operator ==(Lpd3Dblob left, nint right) => left.Handle == right;
		public static bool operator !=(Lpd3Dblob left, nint right) => left.Handle != right;
		public bool Equals(Lpd3Dblob other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is Lpd3Dblob handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("Lpd3Dblob [0x{0}]", Handle.ToString("X"));
		#endif
	}
}