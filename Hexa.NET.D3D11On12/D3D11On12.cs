namespace Hexa.NET.D3D11On12
{
    public static partial class D3D11On12
    {
        static D3D11On12()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "d3d11on12";
        }
    }
}