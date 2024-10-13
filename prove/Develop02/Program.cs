using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        string userChoice = "";

        // Create an instance of the Menu class
        Menu mainMenu = new Menu();

        // Create a new instance of the PromptGenerator class
        PromptGenerator prompt = new PromptGenerator();
        
        // Create a new instance of the Journal class
        Journal theJournal = new Journal();

        while (userChoice != "5")
        {
            mainMenu.DisplayMenu();

            string userInput = Console.ReadLine();
            userChoice = userInput;

            if (userChoice == "1" || userChoice.ToLower() == "write")
            {
                // Create a new instance of the Entry class
                Entry newEntry = new Entry();

                // Get the date
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();   

                Console.WriteLine("Would you like to write about something specific? (yes/no) ");
                string userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("What would you like to write about? (only numbers)");
                    prompt.DisplayPromptThemes();
                    Console.Write(">> ");
                    int userTheme = int.Parse(Console.ReadLine());

                    if (userTheme == 1)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetDailyPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_dailyPrompts" list so it doesn't repeat
                        prompt._dailyPrompts.Remove(newEntry._prompt);
                        
                    }

                    else if (userTheme == 2)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetDreamPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_dreamPrompts" list so it doesn't repeat
                        prompt._dreamPrompts.Remove(newEntry._prompt);
                    }

                    else if (userTheme == 3)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetGoalSettingPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_goalSettingPrompts" list so it doesn't repeat
                        prompt._goalSettingPrompts.Remove(newEntry._prompt);
                    }

                    else if (userTheme == 4)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetFunPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_funPrompts" list so it doesn't repeat
                        prompt._funPrompts.Remove(newEntry._prompt);
                    }

                    else if (userTheme == 5)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetGratitudePrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_gratitudePrompts" list so it doesn't repeat
                        prompt._gratitudePrompts.Remove(newEntry._prompt);
                    }

                    else if (userTheme == 6)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetBrainstormingPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_brainstormingPrompts" list so it doesn't repeat
                        prompt._brainstormingPrompts.Remove(newEntry._prompt);
                    }

                    else if (userTheme == 7)
                    {
                        // Get a random prompt 
                        newEntry._prompt = prompt.GetGenericPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_genericPrompts" list so it doesn't repeat
                        prompt._genericPrompts.Remove(newEntry._prompt);
                    }

                    else
                    {
                        Console.WriteLine("Sorry, I did not understand.");
                    }

                }

                else if (userResponse.ToLower() == "no")
                {
                    Console.WriteLine("Alright, getting a random prompt...");

                    // Get a random prompt 
                        newEntry._prompt = prompt.GetGenericPrompts();
                        
                        // Display the prompt
                        Console.WriteLine(newEntry._prompt);
                        
                        // Allow the user to write an answer
                        Console.Write(">> ");

                        string userEntry = Console.ReadLine();
                        newEntry._entry = userEntry;

                        // Call the AddEntry function to add the new entry to the entries list
                        theJournal.AddEntry(newEntry);
                        
                        // Remove the prompt from the "_dailyPrompts" list so it doesn't repeat
                        prompt._genericPrompts.Remove(newEntry._prompt);
                }

                else
                {
                    Console.WriteLine("This is not a valid Option");
                }
            }

            else if (userChoice == "2" || userChoice.ToLower() == "display")
            {
                // If the user selects "2", display all the entries with the prompts and the date
                theJournal.DisplayAll();
            }

            else if (userChoice =="3" || userChoice.ToLower() == "load")
            {
                // Ask the user for a filename
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string filename = Console.ReadLine();

                Console.WriteLine("\nLoading from file...");

                // Load the prompts, and the answers along with the date from a file
                theJournal.LoadFromFile(filename);
            }
            
            else if (userChoice == "4" || userChoice.ToLower() == "save")
            {
                // Ask the user for a filename
                Console.WriteLine("What is the filename");
                Console.Write("> ");
                string filename = Console.ReadLine();

                Console.WriteLine("\nSaving to file...");

                // Save the prompts, and the answers along with the date to a file
                theJournal.SaveToFile(filename);
            }
            
            else if (userChoice != "5")
            {
                Console.WriteLine("\nThis is not a valid option.\n");
            }
        }
    }
}