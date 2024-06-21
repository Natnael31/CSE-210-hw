using System;
using System.IO;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entry.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entry)
        {
            entry.Display();
        }
    }

    public void saveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Entry entry in _entry)
            {
                outputFile.WriteLine($"Location: {entry._location}\nDate: {entry._date}- prompt: {entry._promptText}\n{entry._entryText}\n");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

    public void loadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}