using System;
using System.Security.Cryptography.X509Certificates;
public class Prompts{
    public string _prompt = "How do you fell today?";    
    public Prompts(){        
    }
    //This codes are hust for testing purposes (to confrm is the list is working, the idea is iterate over all elemments and print the _prompt))
    public void DisplayAPrompt(){
        
        Console.WriteLine(promptList._promptsList);
    }
    PromptList promptList= new PromptList();

    public void DisplayPrompts() {
    foreach (Prompts Promp in promptList._promptsList){
        Promp.DisplayAPrompt();
        
    }
}
    
}

//I really don't know if is necesary to create a new class to make possible to create list that save using the attribute from prompts class
public class PromptList{

    public List<Prompts> _promptsList = new List<Prompts>();    
    public void Prompter(){
    Prompts _promptElem1 = new Prompts();    
    // The idea here is let to be in the list under the same tag
    _promptElem1._prompt = "como te sientes hoy?";

    Prompts _promptElem2 = new Prompts();    
    _promptElem2._prompt = "que te gustaria hacer?";

    Prompts _promptElem3 = new Prompts();    
    _promptElem3._prompt = "Que puedes mejorar?";

    Prompts _promptElem4 = new Prompts();    
    _promptElem4._prompt = "Que hiciste para relajarte?";
    
    Prompts _promptElem5 = new Prompts();    
    _promptElem5._prompt = "Por que crees que debes mejorar?";

    PromptList listingPrompt = new PromptList();

    listingPrompt._promptsList.Add(_promptElem1);
    listingPrompt._promptsList.Add(_promptElem2);
    listingPrompt._promptsList.Add(_promptElem3);
    listingPrompt._promptsList.Add(_promptElem4);
    listingPrompt._promptsList.Add(_promptElem5);}
    
    

}

    



