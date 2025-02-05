using System;
using System.Security.Cryptography.X509Certificates;
public class Prompts{
    public string _prompt = "How do you fell today?";    
    public Prompts(){        
    }
    List<String> _promptsList = new List<String>{"como te sientes hoy?","que te gustaria hacer?","Que puedes mejorar?","Que hice mejor eldia de hoy"};    
    //This codes are hust for testing purposes (to confrm is the list is working, the idea is iterate over all elemments and print the _prompt))
    public void DisplayAPrompt(){
        
        Console.WriteLine(_promptsList[0]);
    }      
}