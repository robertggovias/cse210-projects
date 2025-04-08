// Ex
public class BadHabit : Goal
{
    public BadHabit(
        int goalCounter,
        int goalPoints,
        string goalName,
        string goalDescription,
        bool goalComplete = false,
        string goalType = "Bad Habit"
    )
        : base(goalType, goalCounter, goalPoints, goalName, goalDescription, goalComplete) { }

    public override void CheckGoalComplete()
    {
        SetGoalCompleted(false);
    }

    public override void NewGoal(Goal goal)
    {
        Console.WriteLine("What is the name of your bad habit?");
        goal.SetGoalName(Console.ReadLine());

        Console.WriteLine("What is a short description of it?");
        goal.SetGoalDescription(Console.ReadLine());

        Console.WriteLine("What is the amount of points associated with this bad habit?");
        // Bad habits is different apoach to calculate
        goal.SetGoalPoints(-1 * int.Parse(Console.ReadLine()));
        //sumGoalCounter();
    }

    public override void DisplayGoalForRecord()
    {
        // Exceding requirements: only show not completed goals and motivate showing the points of each
        if (GetGoalCompleted() == false)
        {
            Console.WriteLine(
                $"{GetGoalCounter()}. {GetGoalName()} (You'll lose {GetGoalPoints()} of your points!,but honesty is a virtue)"
            );
        }
    }

    public override void CongratulationsForEventRecord()
    {
        Console.WriteLine($"Is good to recognize it! You lost {-1 * GetGoalPoints()} points!");
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
