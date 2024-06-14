using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        double sum = 0;
        double average = 0;
        int largestNumber = 0;
        long smallestPositiveNumber = 1000000000000000;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int userNumber = int.Parse(Console.ReadLine());

        while (userNumber != 0)
        {   
            numbers.Add(userNumber);
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
        }

        for(int i =0; i<numbers.Count; i++)
        {
            sum += numbers[i];
            if(numbers[i] > largestNumber) 
            {
                largestNumber = numbers[i];
            }
            if(numbers[i] > 0 && numbers[i] < smallestPositiveNumber)
            {
                smallestPositiveNumber = numbers[i];
            }
        }
        average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        for(int i=0; i<numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }
}