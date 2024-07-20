using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();

        Running running = new Running("15 Jul 2024", 30, 3);
        Cycling cycling = new Cycling("16 Jul 2024", 40, 20);
        Swimming summary = new Swimming("17 Jul 2024", 20, 10);

        List<Activity> _activity = new List<Activity>{running, cycling, summary};

        foreach(Activity activity in _activity)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}