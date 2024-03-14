//Brayden McAllister
//March 13, 2024

using static System.Console;

class Program
{
    static void Main()
    {
        Console.Clear();
        bmWelcomeMessage();
        Scripture scripture = bmGetScripture();
        Boolean quit = false;
        while (!quit)
        {
            Console.Clear();
            WriteLine("To hid a word press enter. If you want to quit type quit and hit enter");
            bmDisplayScripture(scripture);
            Write(">");
            string input = ReadLine().ToLower();
            if (input == "quit")
            {
                quit = true;
            }
            else
            {
                quit = bmHideWord(scripture);
            }
        }
    }
    static void bmWelcomeMessage()
    {
        WriteLine("Welcome to the Scripture Memorizer Program");
    }

    //GetScripture
    static Scripture bmGetScripture()
    {
        Write("What scripture would you like to memorize? ");
        string reference = ReadLine();
        Write("What does that scripture say? ");
        string passage = ReadLine();
        Scripture scripture = new Scripture(reference, passage);
        return scripture;
    }

    //DisplayScripture
    static void bmDisplayScripture(Scripture scripture)
    {
        WriteLine(scripture.bmToString());
    }

    //HideWord
    static Boolean bmHideWord(Scripture scripture)
    {
        if (scripture.bmIsDone())
        {
            return true;
        }
        else
        {
            scripture.bmHideWord();
            return false;
        }
    }
}