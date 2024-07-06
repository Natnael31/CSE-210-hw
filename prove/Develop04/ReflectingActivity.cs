using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless" };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    public ReflectingActivity(string name, string description) : base(name, description)
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
        Activity a = new Activity("reflecting", "", seconds);

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Display();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string answer1 = Console.ReadLine();
        Console.Write("Now ponder on each of the following questions as they related in this experience.\nYou may begin: ");
        ShowCountDown(5);
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(10);
        }
        Console.WriteLine();
        Console.WriteLine();
        a.DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        var r = new Random();
        int promptsCount = _prompts.Count;

        int randomPromptIndex = r.Next(promptsCount);
        return _prompts[randomPromptIndex];
    }

    public string GetRandomQuestion()
    {
        var r = new Random();
        int questionsCount = _questions.Count;

        int randomQuestionIndex = r.Next(questionsCount);
        return _questions[randomQuestionIndex];
    }

    public void Display()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
    }

}