using System;

public class Activity
{
    private string _date;
    private int _activityLength;

    public Activity(string date, int length)
    {
        _date = date;
        _activityLength = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }
    
    public virtual double GetDistance()
    {
        return 1;
    }
    public virtual double GetSpeed()
    {
        return 1;
    }
    public virtual double GetPace()
    {
        return 1;
    }
    public virtual string GetSummary()
    {
        return $"{_date}";
    }
}