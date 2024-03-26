using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Create Activities? Maybe?

        Boolean quit = false;
        bmDisplayWelcome();
        while (!quit)
        {
            bmDisplayMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                //Breathing Activity
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.bmRun();
            }
            else if (userInput == "2")
            {
                //Listing Activity
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.bmRun();
            }
            else if (userInput == "3")
            {
                //Reflect Activity
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.bmRun();
            }
            else if (userInput == "4")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }

    static void bmDisplayWelcome()
    {
        Console.WriteLine("Welcome to the Mindfulness Program");
    }

    static void bmDisplayMenu()
    {
        string[] options = new string[]{"Breathing", "Listing", "Reflecting", "Quit"};
        Console.WriteLine("Please pick one of the following activities by entering the the corresponding number");
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i+1}. {options[i]}");
        }
        Console.Write(" > ");
    }
}