using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string type, string email) : base(title, description, date, time, address, type)
    {
        _email = email;
    }

    public string FullDetails()
    {
        return $"{StandardDetails()}\nType of Event: {GetEventType()}\nE-mail: {_email}";
    }
}