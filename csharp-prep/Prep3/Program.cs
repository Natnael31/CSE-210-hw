using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,100);
        Console.WriteLine($"The Random Magic number is : {magicNumber}");
        
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());
        int loop = 0;
        int guessCount = 0;
        
        if (magicNumber == guessNumber)
        {
            Console.WriteLine("You guessed it!");
            guessCount += 1;
        }
        else
        {
            while (loop == 0)
            {   
                guessCount += 1;
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    loop = 1;
                    break;
                }
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine($"The total number of guesses is: {guessCount} ");
        
    }
}