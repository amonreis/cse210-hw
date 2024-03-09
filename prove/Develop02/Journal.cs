using System;
using System.IO;

public class Journal
{
    // A List that holds the date, prompt, and entry
    public List<Entry> _entries = new List<Entry>();
    // A List with the menu
    public List<string> _menu = new List<string>();

    // Displays the menu
    public void DisplayMenu()
    {
        foreach (string a in _menu)
        {
            Console.WriteLine(a);
        }
    }

    public void DisplayEntries()
    {   
        // Iterate through each line and display in this format:
        // Date: DD/MM/YYYY - Prompt \n Entry
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"Date: {e._date} - Prompt: {e._prompt}\n{e._entry}\n");
        }
    }

    public void SaveToFile()
    {   
        // Ask the user for a filename
        Console.WriteLine("What is the filename?");
        Console.Write("> ");
        string filename = Console.ReadLine();

        Console.WriteLine("Saving to file...");

        // Save the entries in a file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"Date: {e._date} - Prompt: {e._prompt}\n{e._entry}\n");
            }
        }
         
    }

    public void ReadFromFile()
    {
        Console.WriteLine("What is the filename?");
        Console.Write("> ");
        string filename = Console.ReadLine();

        Console.WriteLine("Reading from file...");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}