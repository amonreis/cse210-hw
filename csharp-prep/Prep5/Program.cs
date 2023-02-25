using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
    
        DisplayResult(userName, square);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

        
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }


    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}