using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string type, string weatherForecast) : base(title, description, date, time, address, type)
    {
        _weatherForecast = weatherForecast;
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nType of Event: {GetEventType()}\nStatement of Weather: {_weatherForecast}";
    }
}