using System.IO;
using System;
using System.Text;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

public class Journal {
    
    public List<Entry> _entries = new List<Entry>();

    public void Display() {
    foreach (Entry entry1 in _entries)
{
    entry1.Display();
} }

    
    

    public static string _menuOptions= "Please select one of the followeing choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit";
    
            public static string _menuChoice;
            public int _menuChoiceInt;
    
    public Journal(){
        do  {
            Console.WriteLine(_menuOptions);        
            Journal._menuChoice=Console.ReadLine();
            _menuChoiceInt = int.Parse(_menuChoice);
        
        switch (_menuChoiceInt)
    {
        case 1:
        Prompts prompts= new Prompts();
        Console.WriteLine(prompts._prompt);              
        Entry Entry1 = new Entry();        
        /* _entries.Add("salud");
        _entries.Add("compañia"); */
        _entries.Add(Entry1);
        Console.WriteLine($"Date: {Entry1._date} - Prompt: {prompts._prompt} \n{Entry1._entry} ");

        Entries loadList = new Entries();
        //loadList._entries.Add(Entry1._entry);
        //loadList._entries.Add(prompts._prompt);        
        

        //loadList._entries.Add(Entry1._entry);
        //loadList._entries.Add(prompts._prompt);

        break;          

        case 2:        
            Display();        
        
        
               string fileName = "journal.txt";
       string[] lines = System.IO.File.ReadAllLines(fileName);
       //Console.WriteLine(lines);             

       foreach (string line in lines){
        string[] parts = line.Split(',');
        string firstLine = parts[0];
        string secondLine = parts[1];        
        
        Console.WriteLine($"{firstLine}\n{secondLine}\n");
       }
       break;          
       case 3:
        Console.WriteLine("Load");
        break;          
        case 4:
        Console.WriteLine("Save");
        break;          
        case 5:        
        Console.WriteLine("Bye, come back soon");
            break;
        
    }
    }
        while (_menuChoiceInt != 5);
        
    }   
    

  
    
    }
      

  