using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade: ");
        string grade = Console.ReadLine();
        int gradeValue = int.Parse(grade);

        string letter;
        int gradeSign;

        gradeSign = gradeValue % 10; 

        if(gradeValue >= 90)
        {
            letter = "A";
        }
        else if (gradeValue >= 80)
        {
            letter = "B";
        }
        else if (gradeValue >= 70)
        {
            letter = "C";
        }
        else if (gradeValue >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        if (gradeSign >= 7 && letter != "A" && letter != "F")
        {
            Console.WriteLine($"Your garde is {letter}+");    
        }
        else if (gradeSign <3 && letter != "F")
        {
            Console.WriteLine($"Your garde is {letter}-");
        }
        else{
            Console.WriteLine($"Your garde is {letter}");
        }
        
        
        if (gradeValue >= 70) 
        {
            Console.WriteLine("Congratulation you have Passed!");
        }
        else 
        {
            Console.WriteLine("I am sorry you have failed, try to improve next time.");
        }

    }
}