using System;

class Program
{
    static void Main(string[] args)
    {         
        int suma;

        double BrainBreak (double forSquare)
        {
            return Math.Pow (forSquare, 2);
        }
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("Please enter your name: ");        
        string nombre = Console.ReadLine ();  
        Console.WriteLine ("Please enter your favorite number: ");
        string number = Console.ReadLine ();
        int numero = int.Parse (number);

        double squareResult = BrainBreak (numero);
        
        Console.WriteLine ($"Brother {nombre}, the square of your number {numero} is {squareResult}");
    }
}