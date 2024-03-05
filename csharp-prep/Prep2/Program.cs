using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        float gradePercent = float.Parse(Console.ReadLine());
        
        string letter;
        string aOrAn = "a";
        if (gradePercent >= 90)
        {
            letter = "A";
            aOrAn = "an";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        string sign = "";

        if (!(gradePercent > 95 || gradePercent < 60))
        {
            if ((gradePercent % 10) >= 7)
            {
                sign = "+";
            }
            else if ((gradePercent % 10) < 3)
            {
                sign = "-";
            }
        }
        

        Console.WriteLine($"You got {aOrAn} {sign}{letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Yay! You passed the class!");
        }
        else 
        {
            Console.WriteLine("You'll get it next time sport.");
        }
    }
}