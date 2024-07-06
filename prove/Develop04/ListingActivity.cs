using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session?  ");
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        Activity a = new Activity("listing", "", seconds);

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine();
        Console.Write("You may begin: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> list = GetListFromUser();
        while (DateTime.Now < endTime)
        {
            string answer;
            answer = Console.ReadLine();
            list.Add(answer);
            _count += 1;

        }
        Console.WriteLine($"You have listed {list.Count} responses.");
        a.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        var r = new Random();
        int promptsCount = _prompts.Count;

        int randomPromptIndex = r.Next(promptsCount);
        Console.WriteLine($"--- {_prompts[randomPromptIndex]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        return list;
    }
}