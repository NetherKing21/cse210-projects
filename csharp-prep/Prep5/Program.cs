using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        number = SquareNumber(number);
        DisplayResult(name, number);
    }

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        WriteLine("Welcome to the Program");
    }
    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Write("What is your name? ");
        string name = ReadLine();
        return name;
    }
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Write("What is your favorite number? ");
        int favNumber = int.Parse(ReadLine());
        return favNumber;
    }
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        number = number * number;
        return number;
    }
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int number)
    {
        WriteLine($"{name}, the square of your number is {number}");
    }
}