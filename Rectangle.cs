using System;

struct Rectangle
{
    public int Width;
    public int Height;

    public int Area()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1;
        r1.Width = 5;
        r1.Height = 4;

        Rectangle r2 = r1;
        r2.Width = 10;

        Console.WriteLine(r1.Width);
        Console.WriteLine(r2.Width);
    }
}