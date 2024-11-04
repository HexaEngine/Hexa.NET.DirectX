namespace Hexa.NET.X3DAudio
{
    using HexaGen.Runtime;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    public unsafe partial class X3DAudio
    {
        /// <summary>
        /// --------------<br/>
        /// <F<br/>
        /// -U-N-C-T-I-O-N-S>-----------------------------------------//<br/>
        /// initializes instance handle<br/>
        /// </summary>
        [NativeName(NativeNameType.Func, "X3DAudioInitialize")]
        [return: NativeName(NativeNameType.Type, "HRESULT")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static HResult InitializeNative([NativeName(NativeNameType.Param, "SpeakerChannelMask")][NativeName(NativeNameType.Type, "UINT32")] uint speakerChannelMask, [NativeName(NativeNameType.Param, "SpeedOfSound")][NativeName(NativeNameType.Type, "FLOAT32")] float speedOfSound, [NativeName(NativeNameType.Param, "Instance")][NativeName(NativeNameType.Type, "X3DAUDIO_HANDLE")] X3DAudioHandle* instance)
        {
#if NET5_0_OR_GREATER
            return ((delegate* unmanaged[Cdecl]<uint, float, X3DAudioHandle*, HResult>)funcTable[0])(speakerChannelMask, speedOfSound, instance);
#else
			return (HResult)((delegate* unmanaged[Cdecl]<uint, float, nint, HResult>)funcTable[0])(speakerChannelMask, speedOfSound, (nint)instance);
#endif
        }

        /// <summary>
        /// --------------<br/>
        /// <F<br/>
        /// -U-N-C-T-I-O-N-S>-----------------------------------------//<br/>
        /// initializes instance handle<br/>
        /// </summary>
        [NativeName(NativeNameType.Func, "X3DAudioInitialize")]
        [return: NativeName(NativeNameType.Type, "HRESULT")]
        public static HResult Initialize([NativeName(NativeNameType.Param, "SpeakerChannelMask")][NativeName(NativeNameType.Type, "UINT32")] uint speakerChannelMask, [NativeName(NativeNameType.Param, "SpeedOfSound")][NativeName(NativeNameType.Type, "FLOAT32")] float speedOfSound, [NativeName(NativeNameType.Param, "Instance")][NativeName(NativeNameType.Type, "X3DAUDIO_HANDLE")] X3DAudioHandle* instance)
        {
            HResult ret = InitializeNative(speakerChannelMask, speedOfSound, instance);
            return ret;
        }

        /// <summary>
        /// --------------<br/>
        /// <F<br/>
        /// -U-N-C-T-I-O-N-S>-----------------------------------------//<br/>
        /// initializes instance handle<br/>
        /// </summary>
        [NativeName(NativeNameType.Func, "X3DAudioInitialize")]
        [return: NativeName(NativeNameType.Type, "HRESULT")]
        public static HResult Initialize([NativeName(NativeNameType.Param, "SpeakerChannelMask")][NativeName(NativeNameType.Type, "UINT32")] uint speakerChannelMask, [NativeName(NativeNameType.Param, "SpeedOfSound")][NativeName(NativeNameType.Type, "FLOAT32")] float speedOfSound, [NativeName(NativeNameType.Param, "Instance")][NativeName(NativeNameType.Type, "X3DAUDIO_HANDLE")] ref X3DAudioHandle instance)
        {
            HResult ret = InitializeNative(speakerChannelMask, speedOfSound, (X3DAudioHandle*)Unsafe.AsPointer(ref instance));
            return ret;
        }
    }
}