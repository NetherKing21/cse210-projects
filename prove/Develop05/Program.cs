using System;
using System.IO;
using System.Threading.Channels;

class Program
{
    //Base start up
    static bool quit = false;
    static int points = 0;
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        while (!quit)
        {
            bmDisplayMenu();
            bmGetUserInput();
        }
    }

    // Menu
    static void bmDisplayMenu()
    {
        string[] optionList = {"Create New Goal",
                            "List Goals",
                            "Save Goals",
                            "Load Goals",
                            "Record Event",
                            "Quit",
                        };
        Console.Clear();
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();
        Console.WriteLine($"Menu Options:");
        for(int i = 0; i < optionList.Length; i++)
        {
            Console.WriteLine($"  {i+1}. {optionList[i]}");
        }
    }

    // User Input
    static void bmGetUserInput()
    {
        // Ask for and check user input (num must be between 1 and 6)
        bool flag = true;
        do
        {
            try
            {
                Console.WriteLine($"Select an option from the menu: ");
                Console.Write(" > ");
                int input = int.Parse(Console.ReadLine());
                // Call options
                // Try to look for a different way to do this that is not repeating this
                if (input == 1)
                {
                    // Create New Goal
                    flag = false;
                    bmCreateGoal();
                }
                else if (input == 2)
                {
                    // List Goals
                    flag = false;
                    bmListGoals();
                }
                else if (input == 3)
                {
                    // Save Goals
                    flag = false;
                    bmSaveGoals();
                }
                else if (input == 4)
                {
                    // Load Goals
                    flag = false;
                    bmLoadGoals();
                }
                else if (input == 5)
                {
                    // Record Event
                    flag = false;
                    bmRecordEvent();
                }
                else if (input == 6)
                {
                    // Quit
                    flag = false;
                    bmQuit();
                }
                else // Is this ok? throwing one specific error for everything that is not 1-6
                {
                    // if anything else throw flag
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Number must be between 1-6");
            }
        }
        while (flag);
    }

    // Options
    static void bmCreateGoal()
    {
        // Ask for and check user input (num must be between 1 and 6)
        bool flag = true;
        while (flag)
        {
            try
            {
                string[] goalTypes = {"Simple Goal", "Eternal Goal", "Check List Goal"};
                Console.WriteLine($"What type of Goal would you like to make: ");
                for(int i = 0; i < goalTypes.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {goalTypes[i]}");
                }
                Console.Write(" > ");
                int input = int.Parse(Console.ReadLine());
                // Call options
                // Try to look for a different way to do this that is not repeating this
                if (input == 1)
                {
                    // Create simple goal
                    flag = false;
                    bmMakeSimpleGoal();
                }
                else if (input == 2)
                {
                    // Create eternal goal
                    flag = false;
                    bmMakeEternalGoal();
                }
                else if (input == 3)
                {
                    // Create check list goal
                    flag = false;
                    bmMakeCheckListGoal();
                }
                else // Is this ok? throwing one specific error for everything that is not 1-6
                {
                    // if anything else throw flag
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Number must be between 1-3");
            }
        }
    }

    // Making the different goals
    // make simple
    static void bmMakeSimpleGoal()
    {
        Console.Write("What would you like to call this Simple Goal? ");
        string name = Console.ReadLine();

        Console.Write("Please give a description: ");
        string description = Console.ReadLine();

        bool flag = true;
        while(flag)
        {
            try
            {
                Console.Write("Please assign the amount of points for this goal: ");
                int p = int.Parse(Console.ReadLine());

                flag = false;
                SimpleGoal newGoal = new SimpleGoal(name, description, p);
                goals.Add(newGoal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }

    // make eternal
    static void bmMakeEternalGoal()
    {
        Console.Write("What would you like to call this Eternal Goal? ");
        string name = Console.ReadLine();

        Console.Write("Please give a description: ");
        string description = Console.ReadLine();

        bool flag = true;
        while(flag)
        {
            try
            {
                Console.Write("Please assign the amount of points for this goal: ");
                int p = int.Parse(Console.ReadLine());

                flag = false;
                EternalGoal newGoal = new EternalGoal(name, description, p);
                goals.Add(newGoal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }

    // make check list
    static void bmMakeCheckListGoal()
    {
        Console.Write("What would you like to call this Check List Goal? ");
        string name = Console.ReadLine();

        Console.Write("Please give a description: ");
        string description = Console.ReadLine();

        bool flag = true;
        while(flag)
        {
            try
            {
                Console.Write("Please assign the amount of points for this goal: ");
                int p = int.Parse(Console.ReadLine());

                Console.Write("Please assign the amount of bonus points for completing this goal: ");
                int bonus = int.Parse(Console.ReadLine());

                Console.Write("How many times are needed to complete to receive the bonus: ");
                int total = int.Parse(Console.ReadLine());

                flag = false;
                CheckListGoal newGoal = new CheckListGoal(name, description, p, bonus, total);
                goals.Add(newGoal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }

    // More Options
    static void bmListGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("There are no goals listed");
            Console.Write("Press enter when you are ready to continue > ");
            Console.ReadLine();
        }
        else 
        {
            Console.WriteLine("The goals are:");
            int count = 0;
            foreach(Goal goal in goals)
            {
                count++;
                Console.WriteLine($"{count}. "+goal.bmToString());
            }
            Console.Write("Press enter when you are ready to continue > ");
            Console.ReadLine();
        }
    }

    static void bmSaveGoals()
    {
        Console.WriteLine("Enter the name of the file where you would like to save your goals");
        Console.WriteLine("Example \"myfile.txt\"");
        Console.Write(" > ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(points);
            foreach(Goal goal in goals)
            {
                outputFile.WriteLine(goal.bmToCSV());
            }
        }
        Console.WriteLine($"Goals have been saved as \"{fileName}\"");
        Console.WriteLine($"Press enter to return to menu");
        Console.Write(" > ");
        Console.ReadLine();
    }

    static void bmLoadGoals()
    {
        try
        {
            Console.WriteLine("Please enter the name of the file you would like to load");
            Console.Write(" > ");
            string file = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(file);
            points = int.Parse(lines[0]);
            for(int i = 1; i < lines.Length; i++)
            {
                string[] parts1 = lines[i].Split(":");

                string type = parts1[0];
                string[] parts2 = parts1[1].Split(",");

                string name = parts2[0];
                string description = parts2[1];
                int p = int.Parse(parts2[2]);

                if(type == "SimpleGoal")
                {
                    bool completed = bool.Parse(parts2[3]);
                    SimpleGoal newGoal = new SimpleGoal(name, description, p, completed);
                    goals.Add(newGoal);
                }
                else if(type == "EternalGoal")
                {
                    EternalGoal newGoal = new EternalGoal(name, description, p);
                    goals.Add(newGoal);
                }
                else if(type == "CheckListGoal")
                {
                    int bonus = int.Parse(parts2[3]);
                    int total = int.Parse(parts2[4]);
                    int current = int.Parse(parts2[5]);
                    CheckListGoal newGoal = new CheckListGoal(name, description, p, bonus, total, current);
                    goals.Add(newGoal);
                }
            }
            Console.WriteLine($"Goals have been successfully loaded");
            Console.WriteLine($"Press enter to return to menu");
            Console.Write(" > ");
            Console.ReadLine();
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File was not found");
            Console.WriteLine("Press enter to return to menu");
            Console.Write(" > ");
            Console.ReadLine();
        }
    }

    static void bmRecordEvent()
    {
        // Check if there are uncompleted goals
        int uncompleted = 0;
        foreach(Goal goal in goals)
        {
            if(!goal.bmIsCompleted())
            {
                uncompleted++;
            }
        }
        if (uncompleted == 0)
        {
            Console.WriteLine("There are no uncompleted goals");
            Console.Write("Press enter to continue > ");
            Console.ReadLine();
        }
        else 
        {
            // Display uncompleted goals
            Console.WriteLine("The goals are:");
            int count = 0;
            foreach(Goal goal in goals)
            {
                if(goal.bmIsCompleted() == false)
                {
                    count++;
                    Console.WriteLine($"{count}. "+goal.bmToString());
                }
            }
            
            // Get and check user input
            bool flag = true;
            while(flag)
            {
                try
                {
                    Console.WriteLine("Which goal have you completed:");
                    Console.Write(" > ");
                    int input = int.Parse(Console.ReadLine());
                    if(input >= 1 && input <= uncompleted)
                    {
                        flag = false;
                    }
                    else
                    {
                        throw new FormatException();
                    }

                    // Find correct goal from goals using user input
                    // edit input as needed to correct input
                    input--;
                    for(int i = 0; i <= input; i++)
                    {
                        if(goals[i].bmIsCompleted() == true)
                        {
                            input++;
                        }
                    }
                    int pointsEarned = goals[input].bmCalPoints();
                    Console.WriteLine($"Congratulations you earned {pointsEarned} points!");
                    points += pointsEarned;
                    Console.WriteLine($"You now have {points} points");
                    Console.WriteLine("Press enter to return to menu");
                    Console.Write(" > ");
                    Console.ReadLine();
                }
                catch(FormatException)
                {
                    Console.WriteLine($"Please enter a number 1 - {uncompleted}");
                }
            }
        }
    }

    static void bmQuit()
    {
        quit = true;
    }
}