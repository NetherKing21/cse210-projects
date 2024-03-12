// Bradyen McAllister
// March 6, 2024

using System.Runtime.InteropServices;
using System;
using System.IO;

class Program
{
    static Boolean DEBUGFLAG = false;

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Boolean quit = false;
        bmOpeningMessage();
        while(!quit)
        {
            bmDisplayMenu();
            Console.Write("What you like to do? (Enter a number 1-5) ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                journal = bmLoadJournal(journal);
            }
            else if (input == 2)
            {
                bmSaveJournal(journal);
            }
            else if (input == 3)
            {
                journal._entries.Add(bmWriteEntry());
            }
            else if (input == 4)
            {
                DisplayJournal(journal);
            }
            else if (input == 5)
            {
                Console.WriteLine("Program ending");
                quit = true;
            }
            else 
            {
                Console.WriteLine("\nInvalid Response\n");
            }
        }
    }
    static void bmOpeningMessage()
    {
        // Displays opening message for the start of the program
        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Remember to load your journal if you have one.");
    }
    static void bmDisplayMenu()
    {
        // Displays the menu for the user to choose what they want to do (Save Journal, Load Journal, Write Entry, Display Journal)
        string[] options = new string[5]{ "Load Journal", "Save Journal", "Write Entry", "Display Journal", "Quit"};
        for(int i = 0; i < options.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {options[i]}");
        }
    }
    static Entry bmWriteEntry()
    {
        Entry userEntry = new Entry();
        userEntry._bmDate = DateTime.Now.ToShortDateString();
        userEntry._bmPrompt = bmGetRandomPrompt();
        Console.WriteLine($"Prompt: {userEntry._bmPrompt}");
        Console.Write("Enter your response here: ");
        userEntry._bmResponse = Console.ReadLine();
        return userEntry;
    }
    static void DisplayJournal(Journal journal)
    {
        Console.Write(journal.bmToString());
    }
    static void bmSaveJournal(Journal journal)
    {
        string csvForm = journal.bmToCSV();
        Console.Write("What would you like to save your journal as? ");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename))
        { 
            outputFile.Write(csvForm);
        }
        Console.WriteLine("Journal Saved\n");
        DEBUG(csvForm);
    }
    static Journal bmLoadJournal(Journal journal)
    {
        try
        {
            Console.Write("What file would you like to load as your journal? ");
            string filename = Console.ReadLine();
            // Separates CSV into lines
            string[] lines = File.ReadAllLines(filename);
            //Loads lines to be added to the journal as entries
            journal = journal.bmFromString(lines);
            Console.WriteLine("Journal has been loaded\n");
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        return journal;
    }
    static string bmGetRandomPrompt() 
    {
        //Gets a random prompt from a list of prompts to be displayed with the entry
        Random randomNumber = new Random();
        string[] prompts = new string[5]{"Who was the most interesting person I interacted with today?",
                                        "What was the best part of my day?",
                                        "How did I see the hand of the Lord in my life today?",
                                        "What was the strongest emotion I felt today?",
                                        "If I had one thing I could do over today, what would it be?"};
        string returnValue = prompts[randomNumber.Next(0, prompts.Count() - 1)];
        return returnValue;
    }
    static void DEBUG(string message)
    {
        if (DEBUGFLAG == true)
        {
            Console.WriteLine(message);
        }
    }
}