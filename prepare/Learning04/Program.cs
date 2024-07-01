using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());

        Console.WriteLine();

        MathAssignment m = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());

        Console.WriteLine();

        WrittingAssignment w = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine($"{w.GetWrittingInformation()} by {w.GetStudentName()}");
        
    }
}