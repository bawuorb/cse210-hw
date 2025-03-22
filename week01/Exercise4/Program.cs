using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create a list to store the numbers
        List<int> numbers = new List<int>();

        // Step 2: Prompt the user for numbers and add them to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        
        // Loop to add numbers until the user enters 0
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0); // Stop when the user enters 0

        // Core Requirement 1: Calculate the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Core Requirement 2: Calculate the average
        double average = sum / (double)numbers.Count;

        // Core Requirement 3: Find the largest number
        int max = int.MinValue; // Initialize max to the smallest possible integer
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display the core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge 1: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Stretch Challenge 2: Sort the numbers in ascending order
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
