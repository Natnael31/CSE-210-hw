using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        ListGoalNames();
    }

    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goals in _goals)
        {
            string fullInfo = goals.GetDetailString();
            string[] nameFinder = fullInfo.Split();
            Console.WriteLine($"{i}. {nameFinder[2]}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        Console.WriteLine("The Goals are: ");

        foreach (Goal goals in _goals)
        {
            if (goals.IsComplete() == true)
            {
                Console.WriteLine($"[X] {goals.GetName()} ({goals.GetDescription()})");
            }
            else
            {
                Console.WriteLine(goals.GetDetailString());
            }

        }

        Console.WriteLine();

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n  4. Negative Goal");
        Console.Write("Which type of Goal will you like to create? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("What is the name of the Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoal(name, description, points));

        }
        else if (choice == "2")
        {
            Console.Write("What is the name of the Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new EternalGoal(name, description, points));

        }
        else if (choice == "3")
        {
            Console.Write("What is the name of the Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));

        }
        else if (choice == "4")
        {
            Console.Write("What is the name of the Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("What is the penality for commiting this negative goal three times? ");
            int penality = int.Parse(Console.ReadLine());
            _goals.Add(new NegativeGoal(name, description, points, penality));

        }
    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("The Goals are: ");
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        _goals[choice - 1].RecordEvent();
        _score += _goals[choice - 1].GetPoints();
        Console.WriteLine($"You have now {_score} points.");
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goals in _goals)
            {
                outputFile.WriteLine(goals.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            foreach (string part in parts)
            {
                CreateGoalsFromFile(part);
            }

        }

    }

    public List<Goal> CreateGoalsFromFile(string line)
    {
        string[] words = line.Split(",");

        if (words.Length == 4)
        {
            _goals.Add(new SimpleGoal(words[0], words[1], int.Parse(words[2])));
        }
        else if (words.Length == 3)
        {
            _goals.Add(new EternalGoal(words[0], words[1], int.Parse(words[2])));
        }
        else if (words.Length == 6)
        {
            _goals.Add(new ChecklistGoal(words[0], words[1], int.Parse(words[2]), int.Parse(words[3]), int.Parse(words[4])));
        }
        else if (words.Length == 5)
        {
            _goals.Add(new NegativeGoal(words[0], words[1], int.Parse(words[2]), int.Parse(words[3])));
        }

        return _goals;

    }

}