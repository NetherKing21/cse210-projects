using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number1 = new Fraction();
        Fraction number2 = new Fraction(5);
        Fraction number3 = new Fraction(3, 4);
        Fraction number4 = new Fraction(1, 3);

        // Console.WriteLine($"Numerator: {number1.GetTop()}");
        // Console.WriteLine($"Denominator: {number1.GetBottom()}");

        // number1.SetTop(3);
        // number1.SetBottom(4);

        // Console.WriteLine($"New Numerator: {number1.GetTop()}");
        // Console.WriteLine($"New Denominator: {number1.GetBottom()}");

        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetDecimalValue());
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());
        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());
    }
}