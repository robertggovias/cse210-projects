public class SimpleGoals : Goal
{
    public SimpleGoals(int goalCounter, int goalPoints, string goalName, string goalDescription, bool goalComplete = false)
        : base(goalCounter, goalPoints,  goalName, goalDescription, goalComplete) { }

    /* public override void NewGoal()
    {
        // Implementation for creating a new simple goal
    //    Console.WriteLine("New Simple Goal created.");
    }
    public override void RecordEvent()
    {
        // Implementation for recording an event for the goal
     
        Console.WriteLine("Event recorded for Simple Goal.");
    } */

    
}
