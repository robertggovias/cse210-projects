public class EternalGoals : Goal
{
    private int _pointsForGoal;
    public EternalGoals(int points, bool goalComplete, string goalName, string goalDescription, int pointForGoal)
        : base(points, goalComplete, goalName, goalDescription) {
            _pointsForGoal = pointForGoal;
         }

    public override void NewGoal()
    {
        // Implementation for creating a new eternal goal
        Console.WriteLine("New Eternal Goal created.");
    }

    public override bool CheckBox()
    {
        // Eternal goals are never complete
        return false;
    }

    public override void RecordEvent()
    {
        // Implementation for recording an event for the goal
        Console.WriteLine("Event recorded for Eternal Goal.");
    }

    public override void DisplayGoal()
    {
        // Implementation for displaying the goal details
        Console.WriteLine(
            $"Eternal Goal: {_goalName}, Description: {_goalDescription}, Points: {_points}, Complete: {_goalComplete}"
        );
    }
}
