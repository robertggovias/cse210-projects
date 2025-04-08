using System.Diagnostics.Contracts;
using System.Drawing;
using System.Dynamic;

public class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

    protected int _goalTotalPoints = 0;

    private bool _goalCompleted;

    private int _goalCounter = 0;
    private string _goalType;

    public Goal(
        string goalType,
        int goalCounter,
        int goalPoints,
        string goalName,
        string goalDescription,
        bool goalCompleted
    )
    {
        _goalType = goalType;
        _goalCounter = goalCounter;
        _goalPoints = goalPoints;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalCompleted = goalCompleted;
    }

    public virtual void NewGoal(Goal goal)
    {
        Console.WriteLine("What is the name of your goal?");
        goal._goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        goal._goalDescription = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        goal._goalPoints = int.Parse(Console.ReadLine());
        //sumGoalCounter();
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public void SetGoalDescription(string description)
    {
        _goalDescription = description;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public void SetGoalPoints(int points)
    {
        _goalPoints = points;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalName(string name)
    {
        _goalName = name;
    }

    public bool GetGoalCompleted()
    {
        return _goalCompleted;
    }

    protected void SetGoalCompleted(bool completed)
    {
        _goalCompleted = completed;
    }

    public int GetGoalCounter()
    {
        return _goalCounter;
    }

    public void SetGoalCounter(int goalID)
    {
        _goalCounter = goalID;
    }

    public int GetTotalGoalPoints()
    {
        return _goalTotalPoints;
    }

    public void SetTotalGoalPoints(int i)
    {
        _goalTotalPoints = i;
    }

    public virtual void AddTotalGoalPoints(int i)
    {
        _goalTotalPoints = _goalTotalPoints + i;
    }

    public virtual void CheckGoalComplete()
    {
        _goalCompleted = true;
    }

    public string CheckBox()
    {
        if (_goalCompleted == false)
        {
            return "[ ]";
        }
        else
        {
            return "[X]";
        }
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_goalCounter}. {CheckBox()} {_goalName} ({_goalDescription})");
    }

    public virtual void DisplayGoalForRecord()
    {
        // Exceding requirements: only show not completed goals and motivate showing the points of each
        if (_goalCompleted == false)
        {
            Console.WriteLine($"{_goalCounter}. {_goalName} (come on earn {_goalPoints} points!)");
        }
    }

    public virtual void CongratulationsForEventRecord()
    {
        Console.Write($"Congratulations! You have earned {_goalPoints} points!");
    }

    public string _serial;

    public virtual string Serialize()
    {
        return $"{_goalType}|{_goalPoints}|{_goalName}|{_goalDescription}|{_goalCompleted}|{_goalTotalPoints}";
    }

    public string _deserial;

    public virtual void Deserialize(string[] part)
    {
        _goalType = part[0];
        _goalPoints = int.Parse(part[1]);
        _goalName = part[2];
        _goalDescription = part[3];
        _goalCompleted = bool.Parse(part[4]);
        _goalTotalPoints = int.Parse(part[5]);
    }
}
