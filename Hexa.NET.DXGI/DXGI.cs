namespace Hexa.NET.DXGI
{
    public static partial class DXGI
    {
        static DXGI()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "dxgi";
        }
    }
}