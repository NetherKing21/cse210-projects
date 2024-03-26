public class ListingActivity : Activity
{
    private static string type = "Listing Activity";
    private static string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private static string[] prompts = {"Who are people that you appreciate?",
                                        "What are personal strengths of yours?",
                                        "Who are people that you have helped this week?",
                                        "Who are some of your personal heroes?",
                                        "When have you felt the Holy Ghost this month?"};

    //Constructor
    public ListingActivity() : base(type, description) {}

    private void bmMiddle()
    {
        bmDisplayPrompt();
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            // Get user input
            Console.Write(" > ");
            responses.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {responses.Count} items!");
    }

    private string bmRndPrompt()
    {
        Random randomNumber = new Random();
        string returnValue = prompts[randomNumber.Next(prompts.Length)];
        return returnValue;
    }
    private void bmDisplayPrompt()
    {
        string prompt = bmRndPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine("--- "+prompt+" ---\n");
        Console.Write("You may begin in: ");
        bmCountDownAnimation(5);
        Console.WriteLine();
    }
    public void bmRun()
    {
        bmStart();
        bmMiddle();
        bmEnd();
    }
}