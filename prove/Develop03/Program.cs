using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Welcome the user to the Scripture Memorizer Program
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        string filePath = null;

        // Loop until a valid file path is provided
        while (filePath == null || !File.Exists(filePath))
        {
            // Prompt the user to choose a book to memorize from
            Console.WriteLine("\nChoose a book you would like to memorize from:\n");

            Console.WriteLine("1. Old Testament");
            Console.WriteLine("2. New Testament");
            Console.WriteLine("3. Book of Mormon");
            Console.WriteLine("4. Doctrine and Covenants");

            Console.Write("Enter your choice (1-4): ");
            string userChoice = Console.ReadLine();

            // Determine the file path based on the user choice
            if (userChoice == "1")
            {
                filePath = "old_testament.txt";
            }

            else if (userChoice == "2")
            {
                filePath = "new_testament.txt";
            }

            else if (userChoice == "3")
            {
                filePath = "book_of_mormon.txt";
            }

            else if (userChoice == "4")
            {
                filePath = "doctrine_and_covenants.txt";
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue; // Go back to the start of the loop
            }

            // Check if the chosen file path exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found. Please try again.");
                filePath = null; // Set filePath to null to restart the loop.
            }
        }

        // Load scriptures from the chosen file
        List<Scripture> scripturesList = Scripture.LoadScriptures(filePath);

        // Pick a random scripture to display
        Random random = new Random();
        Scripture randomScripture = scripturesList[random.Next(scripturesList.Count)];
        string scriptureText = randomScripture.GetDisplayText();

        // Set the number of words to hide
        int wordsToHide = 2;

        // Keep looping, asking the user until they choose to quit.
        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scriptureText); // Display the current scripture
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();
            // Check if the user wants to quit
            if (input?.ToLower() == "quit") 
                break;

            // Hide words if the scripture is not completely hidden
            if (!randomScripture.IsCompletelyHidden())
            {
                randomScripture.HideRandomWords(wordsToHide);
                scriptureText = randomScripture.GetDisplayText(); // Update displayed text
            }
            else
            {
                break; // Exit the program if all words are hidden
            }

        }
        
        // I added the functionality to choose scriptures from books.
        // Handled the case of randomly choosing from the same letter to hide.
    }
}