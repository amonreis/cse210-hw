using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number for the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int attempts = 0;
        int userGuess = -1;
        string playAgain = "yes";

        // Keep looping until the user guesses the magic number
        while (playAgain.ToLower() == "yes")
        {   
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            
            // Keep track of how many guesses the user has made
            attempts += 1;

            // Display a message if they guess the magic number
            // Display the number of attempts the user made until they guess the number.
            if (userGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you a total of {attempts} attempts.");
               
                // Ask if they want to play again
                Console.Write("Do you want to play again? ");
                playAgain = Console.ReadLine();
                // Generate a new random number
                magicNumber = randomGenerator.Next(1, 100);
                // Reset the attempts
                attempts = 0;
            }

            // If the user guess is higher or lower than the magic number 
            // display a message to help them guess it.
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}