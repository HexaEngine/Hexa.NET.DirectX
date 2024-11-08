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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.X3DAudio
{
	/// <summary>
	/// Listener:<br/>
	/// Defines a point of 3D audio reception.<br/>
	/// The cone is directed by the listener's front orientation.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPX3DAUDIO_LISTENER")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct LpX3DAudioListener : IEquatable<LpX3DAudioListener>
	{
		public LpX3DAudioListener(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpX3DAudioListener Null => new LpX3DAudioListener(0);
		public static implicit operator LpX3DAudioListener(nint handle) => new LpX3DAudioListener(handle);
		public static bool operator ==(LpX3DAudioListener left, LpX3DAudioListener right) => left.Handle == right.Handle;
		public static bool operator !=(LpX3DAudioListener left, LpX3DAudioListener right) => left.Handle != right.Handle;
		public static bool operator ==(LpX3DAudioListener left, nint right) => left.Handle == right;
		public static bool operator !=(LpX3DAudioListener left, nint right) => left.Handle != right;
		public bool Equals(LpX3DAudioListener other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpX3DAudioListener handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("LpX3DAudioListener [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
