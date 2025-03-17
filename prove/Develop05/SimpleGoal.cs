public class SimpleGoals : Goal
{
    public SimpleGoals(int points, bool goalComplete, string goalName, string goalDescription)
        : base(points, goalComplete, goalName, goalDescription) { }

    public override void NewGoal()
    {
        // Implementation for creating a new simple goal
        Console.WriteLine("New Simple Goal created.");
    }

    public override bool CheckBox()
    {
        // Implementation for checking if the goal is complete
        return _goalComplete;
    }

    public override void RecordEvent()
    {
        // Implementation for recording an event for the goal
        _goalComplete = true;
        Console.WriteLine("Event recorded for Simple Goal.");
    }

    public override void DisplayGoal()
    {
        // Implementation for displaying the goal details
        Console.WriteLine(
            $"Simple Goal: {_goalName}, Description: {_goalDescription}, Points: {_points}, Complete: {_goalComplete}"
        );
    }
}
