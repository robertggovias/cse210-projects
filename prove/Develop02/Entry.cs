using System;
public class Entry{
    public string _date;
    public string _prompt;
    public string _entry;
    public Entry(){
        _date = DateTime.Now.ToShortDateString();        
        _entry = Console.ReadLine();
        
    /* public void Display(){
        Console.WriteLine($"{_date}{_prompt}{_entry}");
    }  */
    }}
        
        
    

    