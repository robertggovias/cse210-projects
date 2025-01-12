using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        /*string response;
        do{
            Console.WriteLine("Hello Prep3 World!");
            response = Console.ReadLine();

        }
        while (response == "yes");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        foreach (string s in args)
        {
            Console.WriteLine(s);
        }

        Random randomGenerador = new Random();
        int scoreNumber = randomGenerador.Next(0,50);

        Console.WriteLine("hello" + scoreNumber);*/
        string answer="yes";
        do{
        
        Console.WriteLine("Hello little one, please select a letter: \n a. I'm felling lucky \n b. Just testing, I'll give the magic number \n d. Ok, you win, I'm coward (Ó﹏Ò), I'm out. Get me out of here!");
        string selection = Console.ReadLine();
        if (selection == "a"){
            int magic2Number;
            int magic2NumberGuess;            
            Random randomSuperGenerador = new Random();
            magic2Number = randomSuperGenerador.Next(0, 100);
            int tries = 0;
            
            do{
        Console.WriteLine("What is your guess?");
        string text2Guess = Console.ReadLine();
        magic2NumberGuess = int.Parse(text2Guess);
        tries++;

        
        if (magic2NumberGuess == magic2Number)
        {
            Console.WriteLine($"You guessed it! after trying {tries} times");
        }
        else if (magic2NumberGuess < magic2Number)
        {
            Console.WriteLine("Higer");
        }
        else if (magic2NumberGuess > magic2Number)
        {
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("What wrong with you?");
        }
        }
        while (magic2Number != magic2NumberGuess);
            
        
    }
    else if(selection == "b"){
        Console.WriteLine("What is the magic number?");
        string textNumber = Console.ReadLine();
        int magicNumber = int.Parse(textNumber);
        int magicNumberGuess;
        int tries = 0;
        
        do{
        Console.WriteLine("What is your guess?");
        string textGuess = Console.ReadLine();
        magicNumberGuess = int.Parse(textGuess);
        tries++;
        if (magicNumberGuess == magicNumber)
        {
            Console.WriteLine($"You guessed it! after trying {tries} times");
        }
        else if (magicNumberGuess < magicNumber)
        {
            Console.WriteLine("Higer");
        }
        else if (magicNumberGuess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("What wrong with you?");
        }
        }
        while (magicNumber != magicNumberGuess);
    }
    else{
        Console.WriteLine("Ok. Game over");
    }
    Console.WriteLine("come on! please, say yes, you want to play again");    
    answer = Console.ReadLine();    
    }    
    while (answer == "yes");
    }}
