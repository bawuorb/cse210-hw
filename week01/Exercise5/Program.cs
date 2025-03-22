using System;

class Program
{
    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt for and return the user's favorite number
    static int PromptUserNumber()
    {
        int userNumber;
        bool validInput = false;

        // Keep asking until the user enters a valid number
        while (!validInput)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            validInput = int.TryParse(input, out userNumber); // Try to parse input to an integer

            if (!validInput)
            {
                Console.WriteLine("That's not a valid number. Please enter a valid integer.");
            }
        }

        return userNumber; // Return the valid number after successful input
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result with user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    static void Main()
    {
        // Step 1: Display the welcome message
        DisplayWelcome();

        // Step 2: Get the user's name
        string userName = PromptUserName();

        // Step 3: Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Step 4: Square the user's number
        int squaredNumber = SquareNumber(userNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }
}
