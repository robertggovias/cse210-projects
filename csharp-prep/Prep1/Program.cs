using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        //2 question - 2 answers and finally James bond answer
        Console.WriteLine("What is your first name?");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");


    }
}