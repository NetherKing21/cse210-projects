namespace wrapper
{
    public class all 
    {
        public static void PrintLine(string message="", Boolean end=true)
        {
            if (end)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
        }

        public  static string GetString(string message)
        {
            // Boolean flag = true;
            // while (flag)
            // {
                PrintLine(message, false);
                string userInput = Console.ReadLine();
            // }
            return userInput;
        }
    }
}
