using System;
public class Entry{
    public string _date;
    Prompts _prompts = new Prompts();
    public string _prompte;
    
    
    /* public void promptador(){
        public string _prompter = _prompts._prompt;}  */
    public string _entry;
    
    

    public Entry(){        
        
    }
    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompte}\n{_entry}\n");
    
    }
    public void DisplayComma(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompts._promptsList[0]},{_entry}\n");

    }
    public string GetEntry;
    public string GetEntryListBig(){
        return String.Format($"Date: {_date} - Prompt: {_prompts._promptsList[0]},{_entry}\n");

    }
        
    }
        
        
    

    