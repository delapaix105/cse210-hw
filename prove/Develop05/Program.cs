using System;
using System.Collections.Generic;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int totalScore = 0;

    public static void Main()
    {
        // Example goals
        goals.Add(new SimpleGoal("Run a Marathon", 1000));
        goals.Add(new EternalGoal("Read Scriptures", 100));
        goals.Add(new ChecklistGoal("Attend Temple", 50, 10, 500));

        // Main loop
        while (true)
        {
            try
            {
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Show Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Save Goals");
                Console.WriteLine("6. Load Goals");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Invalid input. Please select an option from the menu.");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        CreateNewGoal();
                        break;
                    case "2":
                        RecordEvent();
                        break;
                    case "3":
                        ShowGoals();
                        break;
                    case "4":
                        ShowScore();
                        break;
                    case "5":
                        SaveGoals();
                        break;
                    case "6":
                        LoadGoals();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    private static void CreateNewGoal()
    {
        // Implementation for creating new goals
    }

    private static void RecordEvent()
    {
        // Implementation for recording events
    }

    private static void ShowGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private static void ShowScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    private static void SaveGoals()
    {
        // Implementation for saving goals
    }

    private static void LoadGoals()
    {
        // Implementation for loading goals
    }
}
