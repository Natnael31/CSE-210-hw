using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate and Time: {_date}, {_time}\nAddress: {_address.GetAddress()} ";
    }

    public string ShortDescription()
    {
         return $"Type of Event: {_type}\nTitle: {_title}\nDate: {_date}";
    }

    public string GetEventType()
    {
        return _type;
    }



}