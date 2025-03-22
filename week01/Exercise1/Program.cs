using System;

class Program
{
    static void Main()
    {
        // Declare variables
        string first_name;
        string last_name;

        // Get user input
        Console.Write("Enter your first name: ");
        first_name = Console.ReadLine();

        Console.Write("Enter your last_name: ");
        last_name = Console.ReadLine();

        // Output the results
        Console.WriteLine($"Hello, {last_name}, {first_name} {last_name} ");
    }
}
