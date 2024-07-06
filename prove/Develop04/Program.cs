using System;
// For extra credit I added the frequency of each activity completed to be displayed when you quit the program.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int breathingCount = 0;
        int reflectionCount = 0;
        int listCount = 0;
        List<int> activityCount = new List<int>();

        string choice = "";

        while (choice.ToLower() != "4")
        {
            Console.WriteLine($"Menu Options:\n   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                b.Run();
                breathingCount += 1;
            }
            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity("reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                r.Run();
                reflectionCount += 1;
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                l.Run();

                listCount += 1;
            }
        }

        Console.WriteLine("Frequency of activities completed: ");
        Console.WriteLine($"Breathing Activity: {breathingCount}");
        Console.WriteLine($"Reflecting Activity: {reflectionCount}");
        Console.WriteLine($"Listing Activity: {listCount}");
    }
}