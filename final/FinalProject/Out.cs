public class Out
{
    public static void bmDisplayStartScreen()
    {
        string[] options = {"Load Game", "New Game", "Quit"};
        Console.WriteLine("Random Adventure Game");
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
        Console.WriteLine("What action would you like to take? ");
        foreach(Entity entity in entities)
        {
            counter++;
            Console.WriteLine($" {counter}. {entity.GetName()}");
        }
    }
}