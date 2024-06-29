using System;

class Program
{
    static void Main(string[] args)
    {
         Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Core Requirement 1: Generate a random magic number between 1 and 100
            int magicNumber = random.Next(1, 101);

            // Core Requirement 2: Ask the user for a guess
            int guess;
            int guessCount = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("Welcome to the Guess My Number game!");

            while (!guessedCorrectly)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Core Requirement 3: Determine if the user needs to guess higher or lower
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessedCorrectly = true;
                }
            }

            // Stretch Challenge 1: Inform the user of the number of guesses
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Stretch Challenge 2: Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}