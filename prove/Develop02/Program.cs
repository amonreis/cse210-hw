using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Set the user choice
        string userOption = "";
        
        // Set the menu
        Journal menu1 = new Journal();
        menu1._menu.Add("\nPlease select one of the following choices:");
        menu1._menu.Add("1. Write");
        menu1._menu.Add("2. Display");
        menu1._menu.Add("3. Save");
        menu1._menu.Add("4. Load");
        menu1._menu.Add("5. Quit");

        //Set the prompts
        PromptGenerator prom = new PromptGenerator();
        prom._prompts.Add("Who was the most interesting person I interacted with today?");
        prom._prompts.Add("What was the best part of my day?");
        prom._prompts.Add("How did I see the hand of the Lord in my life today?");
        prom._prompts.Add("If I had one thing I could do over today, what would it be?");
        prom._prompts.Add("What was the strongest emotion I felt today?");
        prom._prompts.Add("What am I grateful for today?");
        prom._prompts.Add("What was the most fun thing I did today?");
        prom._prompts.Add("What was something important I learn today?");
        prom._prompts.Add("Write a short story that you would like your children and grandchildren to remember you by.");
        prom._prompts.Add("What were the highlights of my day?");
        prom._prompts.Add("What did I accomplish today?");
        prom._prompts.Add("What are some things I want to remember about today?");


        // Create a new instance of the Class "Journal"
        Journal entry = new Journal();

        // Get the date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        // Welcome the user to the program
        Console.WriteLine("Welcome to the Journal Program!");
        
        // Keep displaying the menu to the user until they quit 
        while (userOption != "5")
        {   
            // Display the menu
            menu1.DisplayMenu();

            Console.Write("What would you like to do? ");
            userOption = Console.ReadLine();

            if (userOption == "1")
            {
                // Get a random prompt and store it in a variable. 
                string randPromp = prom.GetRandomPrompt();

                // Display the prompt
                Console.WriteLine(randPromp);

                // Allow the user to write an answer
                Console.Write("> ");
                string new_entry = Console.ReadLine();
                
                Entry ent = new Entry(dateText, randPromp, new_entry);    

                entry._entries.Add(ent);

                // Remove the prompt from the '_prompts' list, so it doesn't repeat
                prom._prompts.Remove(randPromp);


            }

            else if (userOption == "2")
            {
                // Display the entries with the current date and the prompt
                entry.DisplayEntries();
                
            }

            else if (userOption == "3")
            {
                // Save the current date, the prompt, and the answer to a File
                entry.SaveToFile();
            }

            else if (userOption == "4")
            {
                // Read the text from a file
                entry.ReadFromFile();
            }

            else if (userOption != "5")
            {
                Console.WriteLine("That is not a valid option, please select an option (1-5).");
            }
        
        }

    }
}