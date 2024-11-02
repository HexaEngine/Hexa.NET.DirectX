// See https://aka.ms/new-console-template for more information

using System.Numerics;

public struct Vertex
{
    public const int Size = 4 * 3 + 4 * 4;

    public Vector3 Pos;
    public Vector4 Color;

    public Vertex(Vector3 pos, Vector4 color)
    {
        Pos = pos;
        Color = color;
    }
}