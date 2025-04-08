public class EternalGoals : Goal
{
    public EternalGoals(
        int goalCounter,
        int goalPoints,
        string goalName,
        string goalDescription,
        bool goalComplete = false,
        string goalType = "Eternal Goal"
    )
        : base(goalType, goalCounter, goalPoints, goalName, goalDescription, goalComplete) { }

    public override void CheckGoalComplete()
    {
        SetGoalCompleted(false);
    }

    public override void Deserialize(string[] part)
    {
        SetGoalType(part[0]);
        SetGoalPoints(int.Parse(part[1]));
        SetGoalName(part[2]);
        SetGoalDescription(part[3]);
        SetGoalCompleted(bool.Parse(part[4]));
        SetTotalGoalPoints(int.Parse(part[5]));
    }
}
