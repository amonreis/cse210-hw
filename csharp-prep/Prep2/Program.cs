using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        
        // Convert the user input in a float number
        float percentage = float.Parse(Console.ReadLine());
        string letter;
         
        // Calculate the last digit 
        float lastDigit = percentage % 10;
        string sign;

        // Give a sign acording to last digit. Give it a "-" if the last digit is less 
        // than 3. Give it a "+" if it's equal to or greater than 7. 
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
           sign = "-"; 
        }
        else
        {
            sign = "";
        }

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Remove the "A+" grade
        if (percentage >= 97)
        {
            sign = "";
        }

        // Remove the "F+" and "F-" grades
        if (percentage < 60)
        {
            sign = "";
        }

        // Display the letter grade and sign 
        // Displaycongratulation message if they passed the course otherwise
        Console.WriteLine($"Your letter grade is {letter}{sign}");
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you have passed!");
        }
        else if (percentage < 70)
        {
            Console.WriteLine("You have not passed the course. Tuition is available for an additional tuition fee");
        }
    }
}