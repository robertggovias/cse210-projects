using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

Console.Clear();
Scripture scriptureTest = new Scripture(
    "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."
);
Reference referenceTest = new Reference("Isaiah", 41, 1, 3);

void WriteWelcome()
{
    Console.WriteLine("Welcome to memorize Game");
}

void CompleteScripture()
{
    Console.WriteLine(referenceTest.GetReference() + " " + scriptureTest.Display());
}

void WriteRules()
{
    Console.WriteLine(
        "Rules:\n To hide one word hit -> Enter.\n To restore one word write -> back\n Want to insert a new one scripture write -> new.\n If you are tired about memorizing you can write -> quit"
    );
}

void wordCount()
{
    Console.WriteLine($"Total words in the scripture: {scriptureTest.GetWordCount()}");
}

void indexes()
{
    Console.WriteLine($"Hidden words: {scriptureTest.GetCurrentIndex()}");
}
Console.Clear();
WriteWelcome();
void Scripture_rules()
{
    CompleteScripture();
    wordCount();
    indexes();
    WriteRules();
}
Scripture_rules();

string _answer = "";
while (scriptureTest.GetCurrentIndex() < scriptureTest.GetWordCount() && _answer != "quit")
{
    _answer = Console.ReadLine();
    switch (_answer)
    {
        case "":
            Console.Clear();
            WriteWelcome();
            scriptureTest.HideNextWord();
            Scripture_rules();
            break;

        case "back":
            Console.Clear();
            WriteWelcome();
            scriptureTest.restoreLastHiddenWord();
            Scripture_rules();
            break;

        case "new":
            Console.Write("Which book: ");
            string _newBook = Console.ReadLine();
            Console.Write("Which chapter: ");
            int _newChapter = int.Parse(Console.ReadLine());
            Console.Write("Which verse start: ");
            int _newVerseInit = int.Parse(Console.ReadLine());
            Console.Write("Which verse ends: ");
            int _newVerseEnd = int.Parse(Console.ReadLine());

            referenceTest.SetReference(_newBook, _newChapter, _newVerseInit, _newVerseEnd);
            
            Console.Write("Write the scripture: ");
            string _newScripture = Console.ReadLine();
            scriptureTest.setScripture(_newScripture);
            scriptureTest.SetCurrentIndex(0);
            Console.Clear();
            WriteWelcome();
            Scripture_rules();
            break;
    }
}

Console.WriteLine("Bye, come back soon");