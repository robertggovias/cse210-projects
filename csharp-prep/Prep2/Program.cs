using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tell me your score and I will return the grade, capiche?");
        string scoreText = Console.ReadLine();
        int scoreNumber = int.Parse(scoreText);
        int aScore = 100;
        int bScore = 90;
        int cScore = 80;
        int dScore = 70;
        int fScore = 60;

        string aLeter = "A";
        string bLetter = "B";        
        string cLetter = "C";        
        string dLetter = "D";        
        string fLetter = "F";
        //La letra resultado estará en esta variable
        string letter;

        // El mensaje de felicitaciones o de estimulo para mejorar estará en esta variable
        string message = ""; 
        string preMessage  = "";
        
        if (scoreNumber <= aScore && scoreNumber >= bScore)
        {
            letter = aLeter;           
        }
        else if (scoreNumber < bScore && scoreNumber >=cScore)
        {  
            letter = bLetter;
        }
        else if (scoreNumber < cScore && scoreNumber >=dScore)
        {
            letter = cLetter;
        }
        else if (scoreNumber < dScore && scoreNumber >= fScore)
        {
            letter = dLetter;
        }
        else if (scoreNumber < fScore && scoreNumber >= 0)
        {
            letter = fLetter;
        }
        else{
            letter = "sorry that is note a real Score";
        }

        if (scoreNumber <= aScore && scoreNumber >= dScore)
        {
            message = ", congratulations.";            
        }
        else if (scoreNumber < dScore && scoreNumber >= 0)
        {
            message = ", focus Daniel San, come on! cut off your Netflix acount, just for this month, ok.";

        }
        else{
            message="";
        }

        if (scoreNumber <= 100 && scoreNumber >= 0)
        {
            preMessage = "so your grade is";
        }
        else{
            preMessage = "";
        }

        // le coloca el + si la condicion ocurre
        int forSign = scoreNumber%10;    
        string aSign;
        string plusSign = "+";
        string minusSign = "-";

        if (forSign >= 7 && scoreNumber <= 100 && scoreNumber >= 60)
        {
            aSign = plusSign;

        }
        else if (forSign < 7 && scoreNumber <= 100 && scoreNumber >= 60){
            aSign = minusSign;
        }
        else{
            aSign = "";
        }

        
        
        Console.WriteLine($"Ok, your score is {scoreNumber}, {preMessage} {letter}{aSign}{message}");
    }
}