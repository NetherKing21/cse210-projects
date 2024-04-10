using System;
using System.Diagnostics.Tracing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        bool quitGame = false;

        //Game Data
        Player player;
        List<Entity> party = new List<Entity> {};
        List<bool> completedFights;

        while (!quitGame)
        {
            Out.bmDisplayStartScreen();
            int userInput = In.bmGetUserInput(3);
            if(userInput == 1)
            {
                // Load Game State
                Console.WriteLine("you broke it start again");
            }
            else if (userInput == 2)
            {
                // Start/Create New Game
                player = new Player(); //Replace later to get different player classes and return the default
                party.Add(player);
                                                //Undead, Robber, Beast
                completedFights = new List<bool> {false, false, false};
                bmMainGame(party, completedFights);
            }
            else if (userInput == 3)
            {
                // Quit Game
                quitGame = true;
            }
        }
    }

    static void bmMainGame(List<Entity> party, List<bool> completedFights)
    {
        bool quit = false;
        while(!quit)
        {
            Out.bmDisplayMainScreen();
            int userInput = In.bmGetUserInput(6);
            //"Save","Quit","Shop","Undead Fight","Robber Fight","Beast Fight"
            if(userInput == 1)
            {
                //Save
            }
            else if (userInput == 2)
            {
                //Quit
                quit = true;
            }
            else if (userInput == 3)
            {
                //Shop
            }
            else if (userInput == 4)
            {
                //UndeadFight
                Undead e1 = new Undead();
                List<Entity> enemies = new List<Entity>{e1};
                Combat undeadFight = new Combat("Undead Fight", party, enemies);
                completedFights[0] = undeadFight.Fight();
            }
            else if (userInput == 5)
            {
                //RobberFight
                Bandito e1 = new Bandito();
                List<Entity> enemies = new List<Entity>{e1};
                Combat robberFight = new Combat("Robber Fight", party, enemies);
                completedFights[1] = robberFight.Fight();
            }
            else if (userInput == 6)
            {
                //BeastFight
                Beast e1 = new Beast();
                List<Entity> enemies = new List<Entity>{e1};
                Combat robberFight = new Combat("Robber Fight", party, enemies);
                completedFights[2] = robberFight.Fight();
            }

            //Check to see if all the fights are completed
            if(bmCheckCompletion(completedFights))
            {
                Out.bmDisplayCompletionMessage();
                quit = true;
            }
        }
    }

    static void bmCreateNewPlayer()
    {
        //Display options for player
        //Get user input
        //Create player based on input and set to
    }

    static bool bmCheckCompletion(List<bool> bools)
    {
        bool returnValue = true;
        foreach(bool x in bools)
        {
            if(x == false)
            {
                returnValue = false;
            }
        }
        return returnValue;
    }
}