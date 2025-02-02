using System.IO;
using System;
using System.Text;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {     
        Journal journal= new Journal();        
        
        /* Prompts prompts= new Prompts();
        Console.WriteLine(prompts._prompt);              
        Entry Entry1 = new Entry();     */     
        
        //Console.WriteLine($"Date: {Entry1._date} - Prompt: {prompts._prompt} \n{Entry1._entry} numero {journal._menuChoiceInt}");
        /* Entries Entries1= new Entries();


         Entries1._entries.Add(Entry1._date);
        Entries1._entries.Add(Entry1._prompt);
        Entries1._entries.Add(Entry1._entry);
         entries1.Display();
       Console.WriteLine($"I'm entry{Entries1}"); */


 /*       string fileName = "journal.txt";
       string[] lines = System.IO.File.ReadAllLines(fileName);
       //Console.WriteLine(lines);       

       foreach (string line in lines){
        string[] parts = line.Split(',');
        string firstLine = parts[0];
        string secondLine = parts[1];        
        
        Console.WriteLine($"{firstLine}\n{secondLine}\n");
       }   */ 

       
    }
}