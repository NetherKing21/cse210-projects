public class Out
{
    //Attributes
    private static List<Player> classes = new List<Player> {new Player()};

    //Methods
    public static void bmDisplayStartScreen()
    {
        string[] options = {"Load Game", "New Game", "Quit"};
        Console.Clear();
        Console.WriteLine("Random Adventure Game");
        for(int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($" {i+1}. {options[i]}");
        }
    }

    public static void bmDisplayMainScreen()
    {
        string[] options = {"Save","Quit","Shop","Undead Fight","Robber Fight","Beast Fight"};
        Console.Clear();
        Console.WriteLine("You are at the village");
        Console.WriteLine("What would you like to do?");
        for(int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($" {i+1}. {options[i]}");
        }
    }

    public static void bmDisplayActions(List<Action> actions)
    {
        int counter = 0;
        Console.WriteLine("What action would you like to take? ");
        foreach(Action action in actions)
        {
            counter++;
            Console.WriteLine($" {counter}. {action.GetName()}");
        }
    }

    public static void bmDisplayTargets(List<Entity> entities)
    {
        int counter = 0;
        Console.WriteLine("Who would you like attack? ");
        foreach(Entity entity in entities)
        {
            counter++;
            Console.WriteLine($" {counter}. {entity.GetName()}");
        }
    }

    public static void bmDisplayClasses()
    {

    }

    public static void bmActionMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void bmStartCombatMessage()
    {
        Console.Clear();
        Console.WriteLine("You have entered into a fight!");
        Console.WriteLine("Defeat all enemies to win");
        Thread.Sleep(3000);
    }

    public static void bmDisplayCombat(List<Entity> party, List<Entity> enemies)
    {
        Console.Clear();
        foreach(Entity entity in enemies)
        {
            Console.Write($"{entity.GetName()}: {entity.GetHealth()}    ");
        }
        Console.WriteLine("\n");
        foreach(Entity entity1 in party)
        {
            Console.WriteLine($"{entity1.GetName()}: {entity1.GetHealth()}");
        }
        Console.WriteLine();
    }

    public static void bmDisplayCompletionMessage()
    {
        Console.Clear();
        Console.WriteLine("Congratulations! You have completed the Random Adventure Game!");
        Console.WriteLine("You now have the ULTIMATE BRAGGING RIGHTS!!!");
        Thread.Sleep(5000);
    }
}