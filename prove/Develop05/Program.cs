using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {  

        EternalGoals eternal1 = new EternalGoals(5, 0, "", "");
        SimpleGoals simpleGoals1 = new SimpleGoals(5, 0, "", "",true);

        ChecklistGoal checklistGoal = new ChecklistGoal(5, 0,
            "", "", false, 1, 0, 500);            
        

        simpleGoals1.NewGoal(simpleGoals1);
        eternal1.NewGoal(eternal1);
        checklistGoal.NewGoal(checklistGoal);
        

        

        List<Goal> list1 = new List<Goal>();
        //list1 = [simpleGoals1, eternal1];

        int i = 0;
        
        void AddGoalToList(Goal goal)
        {
            i++;
            goal._goalCounter = i;
            list1.Add(goal);            
        }

        AddGoalToList(simpleGoals1);
        Console.Clear();
        AddGoalToList(eternal1);
        Console.Clear();
        AddGoalToList(checklistGoal);
        Console.Clear();

        void ListGoals()
        {
            foreach (Goal goals in list1)
            {
                goals.DisplayGoal();
            }
        }
        ListGoals();
    }
}
