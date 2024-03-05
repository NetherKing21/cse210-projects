using System;

class Program 
{
    static void Main(string[] args) 
    {
        string firstName = GetName("What is your first name? ");
        string lastName = GetName("What is your last name? ");
        PrintLine();
        PrintLine($"Your name is {lastName}, {firstName} {lastName}");
    }

    static void PrintLine(string message="", Boolean end=true)
    {
        if (end)
        {
            Console.WriteLine(message);
        }
        else
        {
            Console.Write(message);
        }
    }

    static string GetName(string message)
    {
        // Boolean flag = true;
        // while (flag)
        // {
            PrintLine(message, false);
            string name = Console.ReadLine();
        // }
        return name;
    }
}