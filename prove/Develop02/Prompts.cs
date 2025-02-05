using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
public class Prompts{
    public string _prompt = "How do you fell today?";    
    public Prompts(){           
    }
    public List<String> _promptsList = new List<String>{"What are your top priorities?","What did you learn today?","What made you feel joy today? ","What are your goals? What can you do to achieve them?","What emotions are you struggling with? How do you handle them?","What are you grateful for? Why are you grateful for it?","What are your fears?","What do you want to achieve in life?","What are your dreams and desires?","What can you do to become the person you want to be? ","What are your health goals?","How can you prioritize your physical and mental health? ","How can you hold yourself accountable?","What can you do to increase your self-discipline?","What's something I can do to make today amazing?","Describe your perfect day.","If you had 3 wishes, what would you wish for?","How has your day been?","Write down 1 thing that always make you smile","What challenges have you faced today?","When do you feel most content and at peace?","Write about a time when you overcame a fear","Write about a memorable childhood experience","Is your current definition of success working for you?","Looking back at your life so far, what moments/events felt successful to you?"};    
    //This codes are hust for testing purposes (to confrm is the list is working, the idea is iterate over all elemments and print the _prompt))

    

    public void randomPrompt (){
        int finalPrompt = _promptsList.Count()-1;
        while (finalPrompt > 0){
            string temporalPropmt = _promptsList[finalPrompt];
            int randomPrompt = new Random().Next (0, finalPrompt);
            _promptsList[finalPrompt] = _promptsList[randomPrompt];
            _promptsList[randomPrompt] = temporalPropmt;
            finalPrompt--;
        }        
    }
    public void DisplayAPrompt(){        
        Console.WriteLine(string.Join(", ", _promptsList));
    }
    
    

    }