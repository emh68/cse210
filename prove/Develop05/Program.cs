using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Display player info");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Choose an option from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateNewGoal(goalManager);
            }
            else if (choice == 2)
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == 3)
            {
                RecordEvent(goalManager);
            }
            else if (choice == 4)
            {
                SaveGoals(goalManager);
            }
            else if (choice == 5)
            {
                LoadGoals(goalManager);
            }
            else if (choice == 6)
            {
                goalManager.DisplayPlayerInfo();
            }
            else if (choice == 7)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    public static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            goalManager.CreateGoal(new SimpleGoal(name, description, points, false, goalManager));
        }
        else if (choice == 2)
        {
            goalManager.CreateGoal(new EternalGoal(name, description, points, goalManager));
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goalManager.CreateGoal(new ChecklistGoal(name, description, points, 0, target, bonus, goalManager));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Enter the name of the goal to record an event: ");
        string goalName = Console.ReadLine();
        goalManager.RecordEvent(goalName);
    }

    public static void SaveGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter a filename to save goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
    }

    public static void LoadGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter a filename to load goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
    }
}