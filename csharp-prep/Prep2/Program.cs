using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that determines the letter grade for a course according to the grade percentage:

        string letter = "";
        string sign = "";

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);


        // Determine the letter grade according to the garde percentage
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        // Determine the sign
        if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }

        // Handle cases like A+, F+, and F-
        if (gradePercentage >= 97)
        {
            sign = "";
        }
        if (gradePercentage < 60)
        {
            sign = "";
        }

        // Display the letter grade along with a message according to the grade percentage
        
        Console.WriteLine($"Your final grade is {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You failed the course! Tutoring is available for an additional fee.");
        }
    }
}