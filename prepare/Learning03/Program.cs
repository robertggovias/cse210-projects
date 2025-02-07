using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction= new Fraction();
        Console.WriteLine(fraction.GetDecimalValue());
        Fraction fraction1= new Fraction(120,40);
        
        Console.WriteLine(fraction1.GetDecimalValue());

        fraction1.SetTop(80);
        Console.WriteLine(fraction.GetDecimalValue());
        fraction.SetBottom(80);
        Console.WriteLine(fraction.GetDecimalValue());
        Fraction fraction2= new Fraction(120);
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
    }
    }