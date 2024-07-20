using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int length, double laps) : base(date, length)
    {
       _laps = laps; 
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 /(1000 * 0.62), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() * 60 / GetActivityLength(), 2);   
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({ GetActivityLength()}min)-Distance {GetDistance()}miles, Speed {GetSpeed()}mph, Pace:{GetPace()} min per mile" ;
    }
}