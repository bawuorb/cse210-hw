using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Step 1: Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

            int guess = 0; // User's guess
            int guessCount = 0; // Counter to track how many guesses the user makes

            Console.WriteLine("Welcome to Guess My Number!");

            // Step 2: Loop to ask for guesses until the user guesses correctly
            while (guess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine()); // Get the user's guess

                // Increment guess counter
                guessCount++;

                // Check if the guess is higher, lower, or correct
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
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Step 3: Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playResponse = Console.ReadLine().ToLower();
            playAgain = playResponse == "yes"; // If user says "yes", continue the loop
        }

        Console.WriteLine("Thanks for playing!");
    }
}
