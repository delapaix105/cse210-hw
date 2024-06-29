using System;

class Program
{
    static void Main(string[] args)
    {// Core Requirement 1: Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Core Requirement 2: Determine the letter grade
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Core Requirement 3: Determine if the user passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }

        // Stretch Challenge 1: Add "+" or "-" to the letter grade
        string sign = "";
        int lastDigit = percentage % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 7)
        {
            sign = "-";
        }

        // Stretch Challenge 2: Display the grade letter with the sign
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}