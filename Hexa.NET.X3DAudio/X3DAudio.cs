namespace Hexa.NET.X3DAudio
{
    public static unsafe partial class X3DAudio
    {
        static X3DAudio()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "x3daudio1_7";
        }
    }
}