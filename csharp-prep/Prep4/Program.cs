using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();       
        
        
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string newNumber;
        do {
            Console.WriteLine("Enter a number: ");
            newNumber = Console.ReadLine();
            list.Add(int.Parse(newNumber));
        }
        while (newNumber != "0");

        int sumaLista = list.Sum();

        Double averageLista = list.Average();

        int MaxLista = list.Max();
        
        
        Console.WriteLine($"The sum is: {sumaLista}");
        Console.WriteLine($"The average is: {averageLista}");
        Console.WriteLine($"The largest number is: {MaxLista}");

        

        list.Sort();

        int minimal = 0;

        foreach (int item in list){            
            if (item <= 0) {
                minimal++;
            }
            else {
                
            }            
        }
        Console.WriteLine(minimal);

        Console.WriteLine($" The smallest positive number is: {list[minimal]}");

        //do while con i para verificar si es negativo

        foreach (int item in list){            
            Console.WriteLine(item);
        }


    }
}