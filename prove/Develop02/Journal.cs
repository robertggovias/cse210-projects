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
public void DisplayComa() {
    foreach (Entry entry in _entries)   {
        
        entry.DisplayComma();
    }

 }
 public void GetEntryList() {
    foreach (Entry entry in _entries)   {
       entry.GetEntryListBig();       
    }

 }

public string _askingFile = "What is the file name?";
    
    

    public static string _menuOptions= "Please select one of the followeing choices: \n 1. Write \n 2. Display unsaverd entries \n 3. Display from file \n 4. Save on file \n 5. Quit";
    
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
        Entry Entry1 = new Entry();                
        _entries.Add(Entry1);
       // Console.WriteLine($"Date: {Entry1._date} - Prompt: {Entry1._prompt} \n{Entry1._entry} ");
        
        break;          

        case 2:        
            DisplayComa();        
        
       break;          
       case 3:
        Console.WriteLine(_askingFile);

        string fileName = Console.ReadLine();
       string[] lines = System.IO.File.ReadAllLines(fileName);
       //Console.WriteLine(lines);             

       foreach (string line in lines){
        string[] parts = line.Split(',');
        string firstLine = parts[0];
        string secondLine = parts[1];        
        
        Console.WriteLine($"{firstLine}\n{secondLine}\n");
       }
        break;          
        case 4:
        GetEntryList();
        Console.WriteLine(_askingFile);
        string newFileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(newFileName)){
            foreach (Entry entry in _entries){
            writer.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt},{entry._entry}\n");
        }}


        break;          
        case 5:
        
        Console.WriteLine("Bye, come back soon");
            break;
        
    }
    }
        while (_menuChoiceInt != 5);
        
    }   
    

  
    
    }
      

  