using static System.Console;
// using c = System.Console;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 100);
            int guess = -1;
            int guessCounter = 0;
            while (guess != magicNumber)
            {
                Write("What is your guess? ");
                guess = int.Parse(ReadLine());
                guessCounter++;

                if (guess < magicNumber)
                {
                    WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    WriteLine("Lower");
                }
                else
                {
                    WriteLine("You got it!");
                }
            }
            WriteLine($"It took you {guessCounter} guess(es).");
            Write("Would you like to play again? ");
            playAgain = ReadLine().ToLower();
        }
    }
}