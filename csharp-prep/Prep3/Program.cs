using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Prompt user for magic number
        Console.Write("What is the magic number?  ");
        string magicNumber = Console.ReadLine();
        // Convert the user input to an integer as: If conversion successful, use 'result'
        if (int.TryParse(magicNumber, out int number))

        // Prompt user for magic number
        Console.Write("What is your guess?  ");
        string guessNumber = Console.ReadLine();
        // Convert the user input to an integer as: If conversion successful, use 'result'
        if (int.TryParse(guessNumber, out int guess))
        {
            if (guess < number)
            {
                Console.WriteLine("Guess Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it");
            }

            Console.WriteLine($"Your Score: {score}, Your grade: {letter}\n");
            {
                if (letter == "A" || letter == "B" || letter == "C" )
                {
                    Console.WriteLine("Congratulations! You have passed the course");
                }
                else
                {
                    Console.WriteLine("Am sorry, I know you tried hard, but you have to try harder next time");
                }

            }
        }
        else
        // Handle exception error in the case that the input is not a valid integer
        {
            Console.WriteLine("Invalid input. Please enter a valid integer as your guess.");
        }
    }
}


