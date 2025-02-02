using System;
public class Entry{
    public string _date;
    public string _prompt;
    public string _entry;
    public Entry(){
        _entry = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();        
    }
    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_entry}");
    
    }}
        
        
    

    