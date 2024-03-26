public class ReflectingActivity : Activity
{
    private static string type = "Reflecting Activity";
    private static string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private static string[] prompts = {"Think of a time when you stood up for someone else.",
                                        "Think of a time when you did something really difficult.",
                                        "Think of a time when you helped someone in need.",
                                        "Think of a time when you did something truly selfless."};
    private static string[] questions = {"Why was this experience meaningful to you?",
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?"};
    private static bool[] beenAskedFlag;

    //Constructor
    public ReflectingActivity() : base(type, description) 
    {
        beenAskedFlag = new bool[questions.Length];
        for(int i = 0; i < questions.Length; i++)
        {
            beenAskedFlag[i] = false;
        }
    }

    private void bmMiddle()
    {
        bmDisplayPrompt();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            bmDisplayQuestion();
            bmSpinnerAnimation(10);
            Console.WriteLine();
        }
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
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine("--- "+prompt+" ---\n");
        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        bmCountDownAnimation(5);
    }
    private void bmDisplayQuestion()
    {
        Random random = new Random();
        //Gets number of how many have not been displayed
        int counter = beenAskedFlag.Length;
        for (int i = 0; i < beenAskedFlag.Length; i++)
        {
            if (beenAskedFlag[i] == true)
            {
                counter--;
            }
        }
        // If all are true reset to false to start again
        if (counter == 0 )
        {
            for (int i = 0; i < beenAskedFlag.Length; i++)
            {
                beenAskedFlag[i] = false;
            }
            counter = beenAskedFlag.Length; 
        }
        // Select random
        int randomInt = random.Next(counter);
        // If that index has been displayed move index
        for (int i = 0; i <= randomInt; i++)
        {
            if (beenAskedFlag[i] == true)
            {
                randomInt++;
            }
        }
        // Change flag
        beenAskedFlag[randomInt] = true;
        // Display question
        Console.Write($" > {questions[randomInt]} ");
    }

    public void bmRun()
    {
        bmStart();
        bmMiddle();
        bmEnd();
    }
}