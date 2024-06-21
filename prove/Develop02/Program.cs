using System;
using System.Security.Cryptography.X509Certificates;

//You can save and load your journal in the file "journal.txt" and for extra credit I added an entry for the location to remind you where you were and saved it at the top of each journal entry. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program!");

        PromptGenerator p = new PromptGenerator();
        Journal j = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        int choice;
        string fileName;

        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        choice = int.Parse(Console.ReadLine());

        while (choice != 5)
        {

            if (choice == 1)
            {
                
                string newPrompt = p.GetRandomPrompt();
                Console.WriteLine(newPrompt);
                string answer1 = Console.ReadLine();
                Console.WriteLine("What location reminds you of that?");
                string answer2 = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._promptText = newPrompt;
                newEntry._entryText = answer1;
                newEntry._location = answer2;
                newEntry._date = dateText;
                j.AddEntry(newEntry);

            }
            else if (choice == 2)
            {
                j.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                j.loadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                j.saveToFile(fileName);
            }
            else if (choice == 5)
            {
                break;
            }

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            choice = int.Parse(Console.ReadLine());
        }
    }
}