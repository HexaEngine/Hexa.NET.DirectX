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
using System.Numerics;
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXGI
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct OutduplDesc
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ModeDesc ModeDesc;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ModeRotation Rotation;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Bool32 DesktopImageInSystemMemory;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe OutduplDesc(ModeDesc modeDesc = default, ModeRotation rotation = default, Bool32 desktopImageInSystemMemory = default)
		{
			ModeDesc = modeDesc;
			Rotation = rotation;
			DesktopImageInSystemMemory = desktopImageInSystemMemory;
		}


	}

}
