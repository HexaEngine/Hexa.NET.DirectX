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
	public partial struct AdapterDesc3
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public char Description_0;
		public char Description_1;
		public char Description_2;
		public char Description_3;
		public char Description_4;
		public char Description_5;
		public char Description_6;
		public char Description_7;
		public char Description_8;
		public char Description_9;
		public char Description_10;
		public char Description_11;
		public char Description_12;
		public char Description_13;
		public char Description_14;
		public char Description_15;
		public char Description_16;
		public char Description_17;
		public char Description_18;
		public char Description_19;
		public char Description_20;
		public char Description_21;
		public char Description_22;
		public char Description_23;
		public char Description_24;
		public char Description_25;
		public char Description_26;
		public char Description_27;
		public char Description_28;
		public char Description_29;
		public char Description_30;
		public char Description_31;
		public char Description_32;
		public char Description_33;
		public char Description_34;
		public char Description_35;
		public char Description_36;
		public char Description_37;
		public char Description_38;
		public char Description_39;
		public char Description_40;
		public char Description_41;
		public char Description_42;
		public char Description_43;
		public char Description_44;
		public char Description_45;
		public char Description_46;
		public char Description_47;
		public char Description_48;
		public char Description_49;
		public char Description_50;
		public char Description_51;
		public char Description_52;
		public char Description_53;
		public char Description_54;
		public char Description_55;
		public char Description_56;
		public char Description_57;
		public char Description_58;
		public char Description_59;
		public char Description_60;
		public char Description_61;
		public char Description_62;
		public char Description_63;
		public char Description_64;
		public char Description_65;
		public char Description_66;
		public char Description_67;
		public char Description_68;
		public char Description_69;
		public char Description_70;
		public char Description_71;
		public char Description_72;
		public char Description_73;
		public char Description_74;
		public char Description_75;
		public char Description_76;
		public char Description_77;
		public char Description_78;
		public char Description_79;
		public char Description_80;
		public char Description_81;
		public char Description_82;
		public char Description_83;
		public char Description_84;
		public char Description_85;
		public char Description_86;
		public char Description_87;
		public char Description_88;
		public char Description_89;
		public char Description_90;
		public char Description_91;
		public char Description_92;
		public char Description_93;
		public char Description_94;
		public char Description_95;
		public char Description_96;
		public char Description_97;
		public char Description_98;
		public char Description_99;
		public char Description_100;
		public char Description_101;
		public char Description_102;
		public char Description_103;
		public char Description_104;
		public char Description_105;
		public char Description_106;
		public char Description_107;
		public char Description_108;
		public char Description_109;
		public char Description_110;
		public char Description_111;
		public char Description_112;
		public char Description_113;
		public char Description_114;
		public char Description_115;
		public char Description_116;
		public char Description_117;
		public char Description_118;
		public char Description_119;
		public char Description_120;
		public char Description_121;
		public char Description_122;
		public char Description_123;
		public char Description_124;
		public char Description_125;
		public char Description_126;
		public char Description_127;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint VendorId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint DeviceId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint SubSysId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Revision;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nuint DedicatedVideoMemory;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nuint DedicatedSystemMemory;

		/// <summary>
		/// To be documented.
		/// </summary>
		public nuint SharedSystemMemory;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Luid AdapterLuid;

		/// <summary>
		/// To be documented.
		/// </summary>
		public AdapterFlag3 Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public GraphicsPreemptionGranularity GraphicsPreemptionGranularity;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ComputePreemptionGranularity ComputePreemptionGranularity;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe AdapterDesc3(char* description = default, uint vendorId = default, uint deviceId = default, uint subSysId = default, uint revision = default, nuint dedicatedVideoMemory = default, nuint dedicatedSystemMemory = default, nuint sharedSystemMemory = default, Luid adapterLuid = default, AdapterFlag3 flags = default, GraphicsPreemptionGranularity graphicsPreemptionGranularity = default, ComputePreemptionGranularity computePreemptionGranularity = default)
		{
			if (description != default(char*))
			{
				Description_0 = description[0];
				Description_1 = description[1];
				Description_2 = description[2];
				Description_3 = description[3];
				Description_4 = description[4];
				Description_5 = description[5];
				Description_6 = description[6];
				Description_7 = description[7];
				Description_8 = description[8];
				Description_9 = description[9];
				Description_10 = description[10];
				Description_11 = description[11];
				Description_12 = description[12];
				Description_13 = description[13];
				Description_14 = description[14];
				Description_15 = description[15];
				Description_16 = description[16];
				Description_17 = description[17];
				Description_18 = description[18];
				Description_19 = description[19];
				Description_20 = description[20];
				Description_21 = description[21];
				Description_22 = description[22];
				Description_23 = description[23];
				Description_24 = description[24];
				Description_25 = description[25];
				Description_26 = description[26];
				Description_27 = description[27];
				Description_28 = description[28];
				Description_29 = description[29];
				Description_30 = description[30];
				Description_31 = description[31];
				Description_32 = description[32];
				Description_33 = description[33];
				Description_34 = description[34];
				Description_35 = description[35];
				Description_36 = description[36];
				Description_37 = description[37];
				Description_38 = description[38];
				Description_39 = description[39];
				Description_40 = description[40];
				Description_41 = description[41];
				Description_42 = description[42];
				Description_43 = description[43];
				Description_44 = description[44];
				Description_45 = description[45];
				Description_46 = description[46];
				Description_47 = description[47];
				Description_48 = description[48];
				Description_49 = description[49];
				Description_50 = description[50];
				Description_51 = description[51];
				Description_52 = description[52];
				Description_53 = description[53];
				Description_54 = description[54];
				Description_55 = description[55];
				Description_56 = description[56];
				Description_57 = description[57];
				Description_58 = description[58];
				Description_59 = description[59];
				Description_60 = description[60];
				Description_61 = description[61];
				Description_62 = description[62];
				Description_63 = description[63];
				Description_64 = description[64];
				Description_65 = description[65];
				Description_66 = description[66];
				Description_67 = description[67];
				Description_68 = description[68];
				Description_69 = description[69];
				Description_70 = description[70];
				Description_71 = description[71];
				Description_72 = description[72];
				Description_73 = description[73];
				Description_74 = description[74];
				Description_75 = description[75];
				Description_76 = description[76];
				Description_77 = description[77];
				Description_78 = description[78];
				Description_79 = description[79];
				Description_80 = description[80];
				Description_81 = description[81];
				Description_82 = description[82];
				Description_83 = description[83];
				Description_84 = description[84];
				Description_85 = description[85];
				Description_86 = description[86];
				Description_87 = description[87];
				Description_88 = description[88];
				Description_89 = description[89];
				Description_90 = description[90];
				Description_91 = description[91];
				Description_92 = description[92];
				Description_93 = description[93];
				Description_94 = description[94];
				Description_95 = description[95];
				Description_96 = description[96];
				Description_97 = description[97];
				Description_98 = description[98];
				Description_99 = description[99];
				Description_100 = description[100];
				Description_101 = description[101];
				Description_102 = description[102];
				Description_103 = description[103];
				Description_104 = description[104];
				Description_105 = description[105];
				Description_106 = description[106];
				Description_107 = description[107];
				Description_108 = description[108];
				Description_109 = description[109];
				Description_110 = description[110];
				Description_111 = description[111];
				Description_112 = description[112];
				Description_113 = description[113];
				Description_114 = description[114];
				Description_115 = description[115];
				Description_116 = description[116];
				Description_117 = description[117];
				Description_118 = description[118];
				Description_119 = description[119];
				Description_120 = description[120];
				Description_121 = description[121];
				Description_122 = description[122];
				Description_123 = description[123];
				Description_124 = description[124];
				Description_125 = description[125];
				Description_126 = description[126];
				Description_127 = description[127];
			}
			VendorId = vendorId;
			DeviceId = deviceId;
			SubSysId = subSysId;
			Revision = revision;
			DedicatedVideoMemory = dedicatedVideoMemory;
			DedicatedSystemMemory = dedicatedSystemMemory;
			SharedSystemMemory = sharedSystemMemory;
			AdapterLuid = adapterLuid;
			Flags = flags;
			GraphicsPreemptionGranularity = graphicsPreemptionGranularity;
			ComputePreemptionGranularity = computePreemptionGranularity;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe AdapterDesc3(Span<char> description = default, uint vendorId = default, uint deviceId = default, uint subSysId = default, uint revision = default, nuint dedicatedVideoMemory = default, nuint dedicatedSystemMemory = default, nuint sharedSystemMemory = default, Luid adapterLuid = default, AdapterFlag3 flags = default, GraphicsPreemptionGranularity graphicsPreemptionGranularity = default, ComputePreemptionGranularity computePreemptionGranularity = default)
		{
			if (description != default(Span<char>))
			{
				Description_0 = description[0];
				Description_1 = description[1];
				Description_2 = description[2];
				Description_3 = description[3];
				Description_4 = description[4];
				Description_5 = description[5];
				Description_6 = description[6];
				Description_7 = description[7];
				Description_8 = description[8];
				Description_9 = description[9];
				Description_10 = description[10];
				Description_11 = description[11];
				Description_12 = description[12];
				Description_13 = description[13];
				Description_14 = description[14];
				Description_15 = description[15];
				Description_16 = description[16];
				Description_17 = description[17];
				Description_18 = description[18];
				Description_19 = description[19];
				Description_20 = description[20];
				Description_21 = description[21];
				Description_22 = description[22];
				Description_23 = description[23];
				Description_24 = description[24];
				Description_25 = description[25];
				Description_26 = description[26];
				Description_27 = description[27];
				Description_28 = description[28];
				Description_29 = description[29];
				Description_30 = description[30];
				Description_31 = description[31];
				Description_32 = description[32];
				Description_33 = description[33];
				Description_34 = description[34];
				Description_35 = description[35];
				Description_36 = description[36];
				Description_37 = description[37];
				Description_38 = description[38];
				Description_39 = description[39];
				Description_40 = description[40];
				Description_41 = description[41];
				Description_42 = description[42];
				Description_43 = description[43];
				Description_44 = description[44];
				Description_45 = description[45];
				Description_46 = description[46];
				Description_47 = description[47];
				Description_48 = description[48];
				Description_49 = description[49];
				Description_50 = description[50];
				Description_51 = description[51];
				Description_52 = description[52];
				Description_53 = description[53];
				Description_54 = description[54];
				Description_55 = description[55];
				Description_56 = description[56];
				Description_57 = description[57];
				Description_58 = description[58];
				Description_59 = description[59];
				Description_60 = description[60];
				Description_61 = description[61];
				Description_62 = description[62];
				Description_63 = description[63];
				Description_64 = description[64];
				Description_65 = description[65];
				Description_66 = description[66];
				Description_67 = description[67];
				Description_68 = description[68];
				Description_69 = description[69];
				Description_70 = description[70];
				Description_71 = description[71];
				Description_72 = description[72];
				Description_73 = description[73];
				Description_74 = description[74];
				Description_75 = description[75];
				Description_76 = description[76];
				Description_77 = description[77];
				Description_78 = description[78];
				Description_79 = description[79];
				Description_80 = description[80];
				Description_81 = description[81];
				Description_82 = description[82];
				Description_83 = description[83];
				Description_84 = description[84];
				Description_85 = description[85];
				Description_86 = description[86];
				Description_87 = description[87];
				Description_88 = description[88];
				Description_89 = description[89];
				Description_90 = description[90];
				Description_91 = description[91];
				Description_92 = description[92];
				Description_93 = description[93];
				Description_94 = description[94];
				Description_95 = description[95];
				Description_96 = description[96];
				Description_97 = description[97];
				Description_98 = description[98];
				Description_99 = description[99];
				Description_100 = description[100];
				Description_101 = description[101];
				Description_102 = description[102];
				Description_103 = description[103];
				Description_104 = description[104];
				Description_105 = description[105];
				Description_106 = description[106];
				Description_107 = description[107];
				Description_108 = description[108];
				Description_109 = description[109];
				Description_110 = description[110];
				Description_111 = description[111];
				Description_112 = description[112];
				Description_113 = description[113];
				Description_114 = description[114];
				Description_115 = description[115];
				Description_116 = description[116];
				Description_117 = description[117];
				Description_118 = description[118];
				Description_119 = description[119];
				Description_120 = description[120];
				Description_121 = description[121];
				Description_122 = description[122];
				Description_123 = description[123];
				Description_124 = description[124];
				Description_125 = description[125];
				Description_126 = description[126];
				Description_127 = description[127];
			}
			VendorId = vendorId;
			DeviceId = deviceId;
			SubSysId = subSysId;
			Revision = revision;
			DedicatedVideoMemory = dedicatedVideoMemory;
			DedicatedSystemMemory = dedicatedSystemMemory;
			SharedSystemMemory = sharedSystemMemory;
			AdapterLuid = adapterLuid;
			Flags = flags;
			GraphicsPreemptionGranularity = graphicsPreemptionGranularity;
			ComputePreemptionGranularity = computePreemptionGranularity;
		}


	}

}
