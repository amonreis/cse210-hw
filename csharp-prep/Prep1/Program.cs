using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        
        // Display the user name on the screen in this format:
        // 'last name', 'first name' 'last name'
       Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}."); 
    }
}