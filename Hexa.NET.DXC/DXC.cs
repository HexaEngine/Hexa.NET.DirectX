namespace Hexa.NET.DXC
{
    public static partial class DXC
    {
        static DXC()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "dxcompiler";
        }
    }
}