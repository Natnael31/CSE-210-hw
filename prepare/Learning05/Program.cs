using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square s = new Square("Green", 5);
        Recatangle r = new Recatangle("Yellow", 5, 4);
        Circle c = new Circle("Red", 5);

        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());
        Console.WriteLine();

        Console.WriteLine(r.GetColor());
        Console.WriteLine(r.GetArea());
        Console.WriteLine();

        Console.WriteLine(c.GetColor());
        Console.WriteLine(c.GetArea());
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Green", 5));
        shapes.Add(new Recatangle("Yellow", 6, 8));
        shapes.Add(new Circle("Red", 10));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color : {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }


    }
}