public class BreathingActivity : Activity
{
    private static string type = "Breathing Activity";
    private static string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    //Constructor
    public BreathingActivity() : base(type, description) {}

    private void bmMiddle()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            bmCountDownAnimation(5);
            Console.Write("\nNow breathe out... ");
            bmCountDownAnimation(5);
            Console.WriteLine();
        }
    }
    public void bmRun()
    {
        bmStart();
        bmMiddle();
        bmEnd();
    }
}