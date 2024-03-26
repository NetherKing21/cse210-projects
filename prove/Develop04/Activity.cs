public class Activity
{
    protected string _type;
    protected string _description;
    protected float _duration;

    protected Activity(string type, string description)
    {
        _type = type;
        _description = description;
    }

    protected void bmStart()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_type}.\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        bmSpinnerAnimation(5);
    }
    protected void bmEnd()
    {
        Console.WriteLine("\nWell done!!!");
        bmSpinnerAnimation(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_type}.");
        bmSpinnerAnimation(5);
        Console.Clear();
    }

    protected void bmSpinnerAnimation(int duration)
    {
        string[] spinner = {"-", "\\", "|", "/"};
        int position = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            position = position % spinner.Length;
            Console.Write(spinner[position]);
            position++;
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        
    }
    protected void bmCountDownAnimation(float duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(duration);
            duration--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}