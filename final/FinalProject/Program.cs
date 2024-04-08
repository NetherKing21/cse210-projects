using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

class Program
{
    static bool quitGame = false;
    static int userInput = 0;

    //Game data
    static Player player;
    static List<Entity> party;
    List<Event> events;

    static void Main(string[] args)
    {
        while (!quitGame)
        {
            bmRunGame();
        }
    }

    static void bmRunGame()
    {
        bmStartScreen();
    }

    static void bmStartScreen()
    {
        Out.bmDisplayStartScreen();
        userInput = In.bmGetUserInput(3);
        if(userInput == 1)
        {
            // Load Game State
        }
        else if (userInput == 2)
        {
            // Start/Create New Game
            bmTestFight();
        }
        else if (userInput == 3)
        {
            // Quit Game
            quitGame = true;
        }
    }

    //Start New game
    static void bmCreateNewGame()
    {
        //Display options for player
        //Get user input
        //Create player based on input and set to global "player"
    }

    static void bmTestFight()
    {
        player = new Player();
        party = new List<Entity> {player};
        Undead e1 = new Undead();
        List<Entity> enemies = new List<Entity>{e1};
        Combat test = new Combat("Test fight", party, enemies);
        bool victory = Combat.Fight();
        if(victory == true)
        {
            Console.WriteLine("You won");
        }
        else
        {
            Console.WriteLine("you lost");
        }
    }
}