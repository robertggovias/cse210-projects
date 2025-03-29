using System.Diagnostics.Contracts;
using System.Drawing;
using System.Dynamic;

public class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;

    protected bool _goalCompleted;

    public int _goalCounter;

    public void sumGoalCounter()
    {
        _goalCounter++;
    }

    public int GetGoalCounter()
    {
        return _goalCounter;
    }

    public int getGoalPoints()
    {
        return _goalPoints;
    }

    public Goal(
        int goalCounter,
        int goalPoints,
        string goalName,
        string goalDescription,
        bool goalCompleted
    )
    {
        _goalCounter = goalCounter;
        _goalPoints = goalPoints;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalCompleted = goalCompleted;
        _goalCounter++;
    }

    public virtual void NewGoal(Goal goal)
    {
        Console.WriteLine("Which type of goal would you like to create?");
        goal._goalPoints = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?");
        goal._goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        goal._goalDescription = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        goal._goalPoints = int.Parse(Console.ReadLine());
    }

    public virtual void RecordEvent() { }

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
        // Implementation for displaying the goal details
        Console.WriteLine(
            $"{_goalCounter}. {CheckBox()} {_goalName} ({_goalDescription}) , pont per goal {_goalPoints}"
        );
    }

    public string _serial;

    public virtual string Serialize()
    {
        return _serial;
    }

    public string _deserial;

    public virtual string Deserialize()
    {
        return _deserial;
    }
}
