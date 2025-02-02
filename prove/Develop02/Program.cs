using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Journal._menuOptions);
        Entry Entry1 = new Entry();
        
        Journal journal= new Journal();
        Console.WriteLine(journal._menuChoice);
        
        Console.WriteLine(Entry1._date);
        Console.WriteLine(Entry1._prompt);
        Console.WriteLine(Entry1._entry);

        Entries entries1= new Entries();


        entries1._entries.Add(Entry1);
       /*  entries1.Display(); */
        
        }
        
}