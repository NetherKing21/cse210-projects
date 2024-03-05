using static System.Console;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbers = new List<float>();
        float number = -1;
        do
        {
            number = GetNumber();
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        
        int count = numbers.Count;
        float sum = FindSum(numbers);
        float average = sum/count;
        double max = FindMax(numbers);
        double positiveMin = FindSmallestPositiveNumber(numbers);
        numbers.Sort();

        WriteLine($"The sum: {sum}");
        WriteLine($"The average: {average}");
        WriteLine($"The max: {max}");
        WriteLine($"The smallest positive number: {positiveMin}");
        WriteLine($"Sorted list:");
        for (int i = 0; i < numbers.Count; i++)
        {
            WriteLine(numbers[i]);
        }
    }

    static float GetNumber()
    {
        Write("Enter a number: ");
        float number = float.Parse(ReadLine());
        return number;
    }

    static float FindSum(List<float> numbers)
    {
        float sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    static double FindMax(List<float> numbers)
    {
        double max = Double.NegativeInfinity;
        foreach (float number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static double FindSmallestPositiveNumber(List<float> numbers)
    {
        double positiveMin = Double.PositiveInfinity;
        foreach (float number in numbers)
        {
            if (number > 0)
            {
                if (number < positiveMin)
                {
                    positiveMin = number;
                }
            }
        }
        return positiveMin;
    }
}