using System;
using System.Reflection.Metadata;

class Program
{
    static bool quitGame = false;
    static int userInput = 0;
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
        }
        else if (userInput == 3)
        {
            // Quit Game
            quitGame = true;
        }
    }
}