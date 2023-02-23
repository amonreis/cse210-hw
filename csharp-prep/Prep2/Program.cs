using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            //Console.WriteLine("Your letter grade is 'A' ");
            letter = "A";
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("Your letter grade is 'B' ");
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

        Console.WriteLine($"Your letter grade is {letter}");

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