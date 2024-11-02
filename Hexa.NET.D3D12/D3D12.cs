namespace Hexa.NET.D3D12
{
    public static partial class D3D12
    {
        static D3D12()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "d3d12";
        }
    }
}