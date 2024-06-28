using System;
using System.IO;

//For extra credit I added an external file from where scriptures are randomly selected. 
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Scripture Meomorizer");
        // Get the scripture from an external file 
        string filePath = "scriptures.txt";
        string[] scriptures = File.ReadAllLines(filePath);

        // Get a random line of script from the scripture array
        string singleScript = "";
        var random = new Random();
        int rand = scriptures.Length;
        int randomScript = random.Next(rand);
        singleScript = scriptures[randomScript];

        // Get the book, chapter, startVerse and endVerse in the line of a script and the count of words in the script 
        string[] wordCount = singleScript.Split(" ");
        int count = wordCount.Length;

        string book = wordCount[0];

        string[] chapterStartVerseEndVerse = wordCount[1].Split(":");
        int chapter = int.Parse(chapterStartVerseEndVerse[0]);

        string[] startVerseEndVerse = chapterStartVerseEndVerse[1].Split("-");
        int startVerse = int.Parse(startVerseEndVerse[0]);
        int endVerse = int.Parse(startVerseEndVerse[1]);

        // Created Instances using constructors 
        Reference r = new Reference(book, chapter, startVerse, endVerse);
        Scripture s = new Scripture(r, singleScript);

        Console.WriteLine(s.GetDisplayText());
        Console.WriteLine("Please enter to continue or type 'quit' to finish:");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "quit")
        {
            var random1 = new Random();
            int randomWord = random1.Next(0, count);
            s.HideRandomWords(randomWord);

            Console.Clear();
            Console.WriteLine(s.GetDisplayText());
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");

            choice = Console.ReadLine();
            if (s.IsCompletelyHidden() == true)
            {
                choice = "quit";
            }
        }

    }
}