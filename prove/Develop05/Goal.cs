using System.Diagnostics.Contracts;
using System.Drawing;
using System.Dynamic;

public class Goal
{
    protected int _points;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _goalComplete;

    public void SetPoints(int point)
    {
        _points = point;
    }

    public int getPoints()
    {
        return _points;
    }

    public Goal objeting = new Goal();

    public Goal() { }

    public Goal(int points, bool goalComplete, string goalName, string goalDescription)
    {
        _points = points;
        _goalComplete = goalComplete;
        _goalName = goalName;
        _goalDescription = goalDescription;
    }

    public virtual void NewGoal() { }

    public virtual bool CheckBox()
    {
        return _goalComplete;
    }

    public virtual void RecordEvent() { }

    public virtual void DisplayGoal() { }
}
