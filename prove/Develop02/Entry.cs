using System;
public class Entry{
    public string _date;

    public string _prompt;
    public string _entry;
    
    Prompts _prompts = new Prompts();
    public Entry(){
        _prompt = _prompts._prompt;
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();        
        
    }
    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n {_entry}\n");
    
    }
    public void DisplayComma(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt},{_entry}\n");

    }
    public string GetEntry;
    public string GetEntryListBig(){
        return String.Format($"Date: {_date} - Prompt: {_prompt},{_entry}\n");

    }
        
    }
        
        
    

    