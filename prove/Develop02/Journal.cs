using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public int _index = 0;

    public void Display()
    {
        foreach (Entry entry1 in _entries)
        {
            entry1.Display();
        }
    }

    public void DisplayComa()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayComma();
        }
    }

    static void randomPrompter()
    {
        Prompts _prompts = new Prompts();
        _prompts.randomPrompt();
    }

    public string _askingFile = "What is the file name?";

    public static string _menuOptions =
        "Please select one of the following choices: \n 1. Write \n 2. Display\n 3. Load \n 4. Save \n 5. Quit";

    public static string _menuChoice;
    public int _menuChoiceInt;

    public Journal()
    {
        Prompts _prompts = new Prompts();
        _prompts.randomPrompt();

        do
        {
            Console.WriteLine(_menuOptions);
            Journal._menuChoice = Console.ReadLine();
            _menuChoiceInt = int.Parse(_menuChoice);

            switch (_menuChoiceInt)
            {
                case 1:
                    _index++;
                    Entry Entry1 = new Entry();
                    //Console.WriteLine(_prompts._prompt);
                    //_prompts.DisplayAPrompt();
                    _prompts._prompt = _prompts._promptsList[_index];
                    Entry1._prompte = _prompts._prompt;
                    Console.WriteLine(Entry1._prompte);
                    Entry1._entry = Console.ReadLine();
                    Entry1._date = DateTime.Now.ToShortDateString();

                    _entries.Add(Entry1);

                    // Console.WriteLine($"Date: {Entry1._date} - Prompt: {Entry1._prompt} \n{Entry1._entry} ");

                    break;

                case 2:
                    Display();

                    break;
                case 3:
                    Console.WriteLine(_askingFile);

                    string fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    //Console.WriteLine(lines);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        Entry entryEntry2 = new Entry();
                        entryEntry2._date = parts[0];
                        entryEntry2._prompte = parts[1];
                        entryEntry2._entry = parts[2];

                        _entries.Add(entryEntry2);
                        //Console.WriteLine($"{firstLine}\n{secondLine}\n");
                    }
                    Display();
                    break;
                case 4:

                    Console.WriteLine(_askingFile);
                    string newFileName = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(newFileName))
                    {
                        foreach (Entry entry in _entries)
                        {
                            writer.WriteLine($"{entry._date},{entry._prompte},{entry._entry}");
                        }
                    }

                    break;
                case 5:

                    Console.WriteLine("Bye, come back soon");
                    break;
                case 6:
                    Console.WriteLine("cuan largo la lista");
                    Console.WriteLine(_entries.Count);
                    break;
            }
        } while (_menuChoiceInt != 5);
    }
}
