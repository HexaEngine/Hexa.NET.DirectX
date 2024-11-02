namespace Hexa.NET.D3D11
{
    public static partial class D3D11
    {
        static D3D11()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "d3d11";
        }
    }
}