using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _location;

    public void Display()
    {
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Date: {_date}- prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}