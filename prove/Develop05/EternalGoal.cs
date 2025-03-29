public class EternalGoals : Goal
{    
    public EternalGoals(int goalCounter, int goalPoints, string goalName, string goalDescription, bool goalComplete = false)
        : base(goalCounter,goalPoints,  goalName, goalDescription, goalComplete)
        {
         }

    public override void RecordEvent()
    {
        // Implementation for recording an event for the goal
        Console.WriteLine("Event recorded for Eternal Goal.");
    }

    
}
