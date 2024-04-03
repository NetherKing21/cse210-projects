using System.Globalization;

public class In
{
    public static int bmGetUserInput(int maxNumber)
    {
        int num = 0;
        bool flag = true;
        while(flag)
        {
            try
            {
                Console.Write(" > ");
                num = int.Parse(Console.ReadLine());
                if(!(num > 0 && num <= maxNumber))
                {
                    throw new FormatException();
                }
                flag = false;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Please enter a number between 1 and {maxNumber}");
            }
        }
        return num;
    }
}