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
using HexaGen.Runtime.COM;

namespace Hexa.NET.DXC
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Define
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe char* Name;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe char* Value;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Define(char* name = default, char* value = default)
		{
			Name = name;
			Value = value;
		}


	}

}
