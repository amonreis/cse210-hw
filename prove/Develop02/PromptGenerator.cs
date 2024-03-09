using System;
using System.Reflection.Metadata.Ecma335;

public class PromptGenerator
{
    // A list that holds the prompts
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        
        // Check the lenght of the '_prompts' list
        int lenght = _prompts.Count();
        
        if (lenght > 0)
        {   
            // Create a new instance of the System class 'Random'
            Random rand = new Random();

            // Select a random number with the same lenght as the list 
            int randprompt = rand.Next(0, lenght);
            string prompt = _prompts[randprompt];

            // return the randomly selected prompt
            return prompt;
             
        }

        return "There are no prompts";

    }
}