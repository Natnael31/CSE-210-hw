using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string type, string speakerName, int capacity) : base(title, description, date, time, address, type)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nType of Event: {GetEventType()}\nSpeaker Name: {_speakerName}\nCpapcity Limit: {_capacity}";
    }
}