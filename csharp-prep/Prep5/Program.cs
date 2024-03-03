using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);
        
        DisplayResult(name, squaredNumber);


        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
            
        }

        // PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }
        
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }
        
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int numberSquared = number * number;

            return numberSquared;
        }

        // DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
        }
    }
}