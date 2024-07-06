using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session?  ");
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        Activity a = new Activity("breathing", "", seconds);

        Console.Write($"Breath in...");
        ShowCountDown(2);
        Console.WriteLine();
        Console.Write($"Now breath out...");
        ShowCountDown(3);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Breath in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write($"Now breath out...");
            ShowCountDown(6);
        }

        Console.WriteLine();
        Console.WriteLine();
        a.DisplayEndingMessage();
    }
}