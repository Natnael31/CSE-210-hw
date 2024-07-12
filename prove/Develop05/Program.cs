using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        string choice = Console.ReadLine();

        while (choice != "6")
        {
            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            else if (choice == "2")
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                goalManager.SaveGoals();
            }
            else if (choice == "4")
            {
                goalManager.LoadGoals();
            }
            else if (choice == "5")
            {
                goalManager.RecordEvent();
            }

            goalManager.Start();
            choice = Console.ReadLine();
        }

    }
}