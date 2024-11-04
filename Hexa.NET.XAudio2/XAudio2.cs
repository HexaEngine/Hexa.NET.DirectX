namespace Hexa.NET.XAudio2
{
    public static partial class XAudio2
    {
        static XAudio2()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "xaudio2_9";
        }
    }
}