using System;
using System.ComponentModel.DataAnnotations;

public class Recatangle : Shape
{
    private double _length;
    private double _width;

    public Recatangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

}