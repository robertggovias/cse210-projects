using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture scriptureTest = new Scripture("Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.");
        Reference referenceTest = new Reference("Isaiah",41,1,3);                        
        //Word weird =  new Word("test");
        Console.WriteLine(referenceTest.GetReference() + " " + scriptureTest.GetScripture());
        int i = 0;        
        string _finish = "";
        do {
            _finish = Console.ReadLine();
            if (_finish == "back") {                
                scriptureTest.wordrestore();
                Console.Clear();
                Console.WriteLine(referenceTest.GetReference()+" "+ scriptureTest.DisplayScriptureList()); 
                i--;
            } else {
            Console.Clear();
            scriptureTest.CreateHiddenWordIndex(i);
            Console.WriteLine(referenceTest.GetReference()+" "+ scriptureTest.DisplayScriptureList()); 
                       
            i++;
            }
        }
        while(scriptureTest._hiddenWord_List_index.Count < scriptureTest.Get_wordys_Count() && _finish != "quit");       
        
        
        }
}