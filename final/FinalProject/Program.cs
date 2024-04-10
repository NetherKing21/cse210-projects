using System;
using System.Diagnostics.Tracing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool quitGame = false;

        //Game Data
        Player player;
        List<Entity> party = new List<Entity> {};
        // Ians list of players so the store works
        List<Player> imParty = new List<Player>();
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
                imParty.Add(player);
                bmCreateNewPlayer(party);
                                                //Undead, Robber, Beast
                completedFights = new List<bool> {false, false, false};
                bmMainGame(party, imParty, completedFights);
            }
            else if (userInput == 3)
            {
                // Quit Game
                quitGame = true;
            }
        }
    }

    static void bmMainGame(List<Entity> party, List<Player> imParty, List<bool> completedFights)
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
                Store store = new Store(imParty);
                store.ImRun();
            }
            else if (userInput == 4)
            {
                //UndeadFight
                Undead e1 = new Undead();
                List<Entity> enemies = new List<Entity>{e1};
                Combat undeadFight = new Combat("Undead Fight", party, imParty, enemies);
                completedFights[0] = undeadFight.Fight();
            }
            else if (userInput == 5)
            {
                //RobberFight
                Bandito e1 = new Bandito();
                List<Entity> enemies = new List<Entity>{e1};
                Combat robberFight = new Combat("Robber Fight", party, imParty, enemies);
                completedFights[1] = robberFight.Fight();
            }
            else if (userInput == 6)
            {
                //BeastFight
                Beast e1 = new Beast();
                List<Entity> enemies = new List<Entity>{e1};
                Combat robberFight = new Combat("Robber Fight", party, imParty, enemies);
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

   static void bmCreateNewPlayer(List<Entity> party)
    {
        Console.WriteLine("Choose a player: ");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Ranger");
        Console.WriteLine("3. Aayush");
        int userInput = In.bmGetUserInput(3);

        if (userInput == 1)
        {
            Warrior player = new Warrior();
            party.Add(player);
            Console.WriteLine("Warrior selected.");
        }
        else if (userInput == 2)
        {
            Ranger player = new Ranger();
            party.Add(player);
            Console.WriteLine("Ranger selected.");
        }
        else if (userInput == 3)
        {
            Aayush player = new Aayush();
            party.Add(player);
            Console.WriteLine("Aayush selected.");
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to Warrior.");
            Warrior player = new Warrior();
            party.Add(player);
        }
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