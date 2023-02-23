using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        // Convert the string to an integer number
        int grade = int.Parse(userInput);
        
        string letter = "";
        string sign = "";
        int last_digit = grade % 10;
        
        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60 )
        {   
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        // Stretch Challenge 1
        if (last_digit >= 7)
        {
           sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }

        // Stretch Challenge 2
        if (grade > 93)
        {
            sign = "";
        }

        // Stretch Challenge 3
        if (letter == "F")
        {
            sign = "";
        }

        // Display the letter grade for the user to see
        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        // Inform the user if they passed the course or not
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations on your well-deserved success. You have passed!! Best wishes for your next adventure!.");
        }
        else
        {
            Console.WriteLine("You did not pass this course, tutoring is available for an additional fee!");
        }
    }
}