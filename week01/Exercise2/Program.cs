using System;

class Program
{
    static void Main()
    {
        // Step 1: Ask for the user's grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Step 2: Declare a variable to hold the letter grade and the sign
        string letterGrade = "";
        string sign = "";

        // Step 3: Determine the letter grade using if-else statements
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            // Determine the sign for A
            if (gradePercentage >= 97)
            {
                sign = "+"; // A+
            }
            else if (gradePercentage <= 92)
            {
                sign = "-"; // A-
            }
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
            // Determine the sign for B
            if (gradePercentage >= 87)
            {
                sign = "+"; // B+
            }
            else if (gradePercentage <= 82)
            {
                sign = "-"; // B-
            }
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
            // Determine the sign for C
            if (gradePercentage >= 77)
            {
                sign = "+"; // C+
            }
            else if (gradePercentage <= 72)
            {
                sign = "-"; // C-
            }
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
            // Determine the sign for D
            if (gradePercentage >= 67)
            {
                sign = "+"; // D+
            }
            else if (gradePercentage <= 62)
            {
                sign = "-"; // D-
            }
        }
        else
        {
            letterGrade = "F";
            sign = ""; // No F+ or F-
        }

        // Step 4: Display the letter grade and sign
        string finalGrade = letterGrade + sign;
        Console.WriteLine($"Your grade is: {finalGrade}");

        // Step 5: Check if the user passed and display the appropriate message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, try again next time.");
        }
    }
}
