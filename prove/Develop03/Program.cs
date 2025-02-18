using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture scriptureTest = new Scripture("Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness.");
        Reference referenceTest = new Reference("Isaiah",41,1,3);                        
        //Word weird =  new Word("test");
        void WriteWelcome(){
            Console.WriteLine("Welcome to memorize Game");
        }
        WriteWelcome();
        Console.WriteLine(referenceTest.GetReference() + " " + scriptureTest.GetScripture());
         void WriteRules(){
            Console.WriteLine("Rules:\n To hide one word hit -> Enter.\n To restore one word write -> back\n Want to insert a new one scripture write -> new.\n If you are tired about memorizing you can write -> quit");        
        }
        WriteRules();
        int i = 0;        
        string _answer = "";
        do {
            _answer = Console.ReadLine();
            switch (_answer)
            
            {
                case "":
                Console.Clear();
            WriteWelcome();
            scriptureTest.CreateHiddenWordIndex(i);
            Console.WriteLine(referenceTest.GetReference()+" "+ scriptureTest.DisplayScriptureList());
            WriteRules();
            i++;
            break;
            // My first streatch goal -> restore hidden words in the same order


             case "back":
              if (scriptureTest._hiddenWord_List_index.Count > 0)
            {   
                scriptureTest.wordrestore();
                Console.Clear();
                WriteWelcome();
                Console.WriteLine(referenceTest.GetReference()+" "+ scriptureTest.DisplayScriptureList());                 
                i--;
                WriteRules();
            }
            break;
            
// Second strecht goal -> create new object for a new scripture an reference - but I doubt if this is the correct way, because before ending get error
                case "new":
                       Console.Write("Which book: ");
                string _newBook=Console.ReadLine();
                Console.Write("Which chapter: ");
                int _newChapter=int.Parse(Console.ReadLine());
                Console.Write("Which verse start: ");
                int _newVerseInit=int.Parse(Console.ReadLine());
// I have troubles creating the verseEnd
                //Console.Write("Which verse ends: ");
                //int _newVerseEnd=int.Parse(Console.ReadLine());                
                Reference new_ReferenceTest = new Reference(_newBook,_newChapter,_newVerseInit);
                
                Console.Write("Write the scripture: ");
                string _newScripture=Console.ReadLine();
                Scripture new_ScriptureTest = new Scripture(_newScripture);
                do{
                Console.Clear();                
                Console.WriteLine(new_ReferenceTest.GetReference()+" "+ new_ScriptureTest.DisplayScriptureList());                 
                _answer = Console.ReadLine();
                if (_answer == "back" && new_ScriptureTest._hiddenWord_List_index.Count > 0)
            {   
                new_ScriptureTest.wordrestore();
                Console.Clear();
                WriteWelcome();
                Console.WriteLine(new_ReferenceTest.GetReference()+" "+ new_ScriptureTest.DisplayScriptureList());                 
                i--;
                WriteRules();
            }
            else{
            Console.Clear();
            WriteWelcome();
            new_ScriptureTest.CreateHiddenWordIndex(i);
            Console.WriteLine(new_ReferenceTest.GetReference()+" "+ new_ScriptureTest.DisplayScriptureList());
            WriteRules();
            i++;            
            }}while(new_ScriptureTest._hiddenWord_List_index.Count < new_ScriptureTest.Get_wordys_Count() && _answer != "quit");
break;
            }
            
           
           
      
            // The firs if let to use de word back ot restore the last word hidden and so on           
        }
        while(scriptureTest._hiddenWord_List_index.Count < scriptureTest.Get_wordys_Count() && _answer != "quit");
        Console.WriteLine("Bye, come back soon");      
    }}