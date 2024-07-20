using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
       _distance = distance; 
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance * 60 / GetActivityLength(), 2);   
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({ GetActivityLength()}min)-Distance {GetDistance()}miles, Speed {GetSpeed()}mph, Pace:{GetPace()} min per mile" ;
    }
}