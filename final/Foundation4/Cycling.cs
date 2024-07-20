using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * GetActivityLength() / 60, 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetActivityLength()}min)-Distance {GetDistance()}miles, Speed {GetSpeed()}mph, Pace:{GetPace()} min per mile";
    }
}