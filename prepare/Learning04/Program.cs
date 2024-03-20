using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Brayden McAllister", "Section 7.3", "Problems 8-19", "Fractions");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Brayden McAllister", "European History", "The Causes fo World War II");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}