public class Out
{
    //Attributes
    private static List<Player> classes = new List<Player> {new Player()};

    //Methods
    public static void bmDisplayStartScreen()
    {
        string[] options = {"Load Game", "New Game", "Quit"};
        Console.WriteLine("Random Adventure Game");
        for(int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($" {i+1}. {options[i]}");
        }
    }

    public static void bmDisplayMainScreen()
    {
        string[] options = {"Save","Quit","Shop","Undead Fight","Robber Fight","Beast Fight"};
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
        
    }

    public static void bmDisplayCombat()
    {
        //
    }
}