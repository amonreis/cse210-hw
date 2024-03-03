using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of numbers to store numbers from the user inputs.
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        float sum = 0;

        while (number != 0)
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                // Add the number to the numbers list
                numbers.Add(number);
            }
        }

        // Remove the last entry from the user so it doesn't get in the way of our calculations.
        // numbers.Remove(0);
        //numbers.RemoveAt(numbers.Count -1);

        // Sum all the numbers in the list
        foreach (int numb in numbers)
        {
            sum += numb ;
        }

        // Find the avarege
        float average = sum / numbers.Count;

        // Find the largest number
        float largestNumber = numbers[0];

        foreach (int numb in numbers)
        {
            if (largestNumber < numb)
            {
                largestNumber = numb;
            }
        }

        // Display the total
        Console.WriteLine($"The sum is: {sum}");
        // Display the average
        Console.WriteLine($"The average is: {average}");
        // Display The largest number
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}