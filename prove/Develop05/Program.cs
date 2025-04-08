using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goalList = new List<Goal>();

        void menu()
        {
            int answer = 10;

            while (answer != 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to your eternal success journey!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have {AllPointsTotal()} right now.\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(
                    $"Menu options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Goals\n   6. Quit"
                );
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Select a choice from the menu: ");
                Console.ForegroundColor = ConsoleColor.White;
                answer = int.Parse(Console.ReadLine());
                Console.Clear();
                {
                    switch (answer)
                    {
                        case 1:
                            MenuGoals();
                            break;
                        case 2:
                            ListGoals();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 3:
                            SaveGoals();
                            break;
                        case 4:
                            LoadFile();
                            //LoadGoals();
                            break;
                        case 5:
                            RecordEvent();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                            //RecordEvent();
                            break;
                        case 6:
                            Console.WriteLine("Thanks for using our system");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
            }
        }

        int goalID = 1;

        void AddGoalToList(Goal goal)
        {
            goal.SetGoalCounter(goalID);
            goalID++;
            goal.NewGoal(goal);
            _goalList.Add(goal);
        }

        void ListGoals()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Goals are:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Goal goals in _goalList)
            {
                goals.DisplayGoal();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"You have points {AllPointsTotal()}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        void ListGoalsForRecord()
        {
            foreach (Goal goal in _goalList)
            {
                goal.DisplayGoalForRecord();
            }
        }
        void MenuGoals()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "The types of Goal are:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   1. Simple Goal\n   2. Eternal Goal\n   3. Checklitst Goal\n   4. Bad Habit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Select a choice from the menu: ");
            int answer1 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            switch (answer1)
            {
                case 1:
                    AddGoalToList(new SimpleGoals(0, 0, "", "", false));
                    break;
                case 2:
                    AddGoalToList(new EternalGoals(0, 0, "", "", false));
                    break;
                case 3:
                    AddGoalToList(new ChecklistGoal(0, 0, "", "", false, 1, 0, 500));

                    break;
                case 4:
                    AddGoalToList(new BadHabit(0, 0, "", "", false));
                    break;
            }
        }
        void SaveGoals()
        {
            Console.WriteLine("What is the filename for the goal");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal goals in _goalList)
                {
                    outputFile.WriteLine(goals.Serialize());
                }
            }
        }
        int AllPointsTotal()
        {
            int fullPoints = 0;
            foreach (Goal goals in _goalList)
            {
                fullPoints = fullPoints + goals.GetTotalGoalPoints();
            }
            return fullPoints;
        }

        void RecordEvente(int i)
        {
            foreach (Goal goals in _goalList)
            {
                if (i == goals.GetGoalCounter() && goals.GetGoalCompleted() == false)
                {
                    goals.AddTotalGoalPoints(goals.GetGoalPoints());
                    goals.CheckGoalComplete();
                    goals.CongratulationsForEventRecord();
                }
                else
                {
                    goals.AddTotalGoalPoints(goals.GetGoalPoints());
                    Console.WriteLine();
                }
            }
        }
        void RecordEvent()
        {
            ListGoalsForRecord();
            Console.Write("Which goal did you accomplish: ");
            int i = int.Parse(Console.ReadLine());
            RecordEvente(i);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You have {AllPointsTotal()} points.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        void Serialize()
        {
            foreach (Goal goals in _goalList)
            {
                Console.WriteLine(goals.Serialize());
            }
        }
        void LoadFile()
        {
            Console.WriteLine("What is the filename for the goal file?");
            string filename = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                switch (parts[0])
                {
                    case "Simple Goal":
                        Goal SimpleGoalObject = new SimpleGoals(goalID, 0, "", "", false);
                        SimpleGoalObject.Deserialize(parts);
                        _goalList.Add(SimpleGoalObject);
                        break;
                    case "Eternal Goal":
                        Goal EternalGoalObject = new EternalGoals(goalID, 0, "", "", false);
                        EternalGoalObject.Deserialize(parts);
                        _goalList.Add(EternalGoalObject);
                        break;
                    case "Checklist Goal":
                        Goal ChecklistGoalObject = new ChecklistGoal(
                            goalID, 0, "", "", false, 1, 0, 500);
                        ChecklistGoalObject.Deserialize(parts);
                        _goalList.Add(ChecklistGoalObject);
                        break;
                    case "Bad Habit":
                        Goal BadHabitObject = new BadHabit(goalID, 0, "", "", false);
                        BadHabitObject.Deserialize(parts);
                        _goalList.Add(BadHabitObject);
                        break;
                }
                goalID++;
            }
        }

        menu();

        ListGoals();
    }
}
