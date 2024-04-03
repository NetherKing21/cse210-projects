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
}