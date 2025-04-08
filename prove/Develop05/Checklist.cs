public class ChecklistGoal : Goal
{
    private int _currentTimesGoal;
    private int _bonusRequiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(
        int goalCounter,
        int goalPoints,
        string goalName,
        string goalDescription,
        bool goalCompleted,
        int bonusPoints,
        int currentTimesGoal,
        int bonusRequiredTimes,
        string goalType = "Checklist Goal"
    )
        : base(goalType, goalCounter, goalPoints, goalName, goalDescription, goalCompleted)
    {
        _currentTimesGoal = currentTimesGoal;
        _bonusRequiredTimes = bonusRequiredTimes;
        _bonusPoints = bonusPoints;
    }

    public override void NewGoal(Goal goal)
    {
        Console.WriteLine("What is the name of your goal?");
        SetGoalName(Console.ReadLine());

        Console.WriteLine("What is a short description of it?");
        SetGoalDescription(Console.ReadLine());

        Console.WriteLine("What is the amount of points associated with this goal?");
        SetGoalPoints(int.Parse(Console.ReadLine()));

        Console.WriteLine("How many times does this goal need to be accomlished for a bonus?");
        _bonusRequiredTimes = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void CheckGoalComplete()
    {
        if (_currentTimesGoal >= _bonusRequiredTimes)
        {
            SetGoalCompleted(true);
            // Exeding requirements: a message when you complete the checklist goal
            Console.WriteLine(
                $"You {GetGoalName()} {_bonusRequiredTimes}, you completed it, you're awesome! you eraned the {_bonusPoints} bounus points!"
            );
        }
    }

    public override void AddTotalGoalPoints(int i)
    {
        _currentTimesGoal++;
        if (_currentTimesGoal == _bonusRequiredTimes)
        {
            _goalTotalPoints = _goalTotalPoints + GetGoalPoints();
            _goalTotalPoints = _goalTotalPoints + _bonusPoints;
        }
        else if (_currentTimesGoal <= _bonusPoints)
        {
            _goalTotalPoints = _goalTotalPoints + GetGoalPoints();
        }
        else
        {
            i = _goalTotalPoints + 0;
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine(
            $"{GetGoalCounter()}. {CheckBox()} {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {_currentTimesGoal}/{_bonusRequiredTimes}"
        );
    }

    // Exceding requirements: calculate how many goals are need to be accomplished to earn a big bonus
    public int GoalsNeededToEarnBonusNow()
    {
        return _bonusRequiredTimes - _currentTimesGoal;
    }

    public override void DisplayGoalForRecord()
    {
        // Exceding requirements: only show not completed goals and motivate showing the points of each
        if (GetGoalCompleted() == false)
        {
            Console.WriteLine(
                $"{GetGoalCounter()}. {GetGoalName()} (come on earn {GetGoalPoints()} points!) - accomplish {GoalsNeededToEarnBonusNow()} times to earn {_bonusPoints} points."
            );
        }
    }

    public override string Serialize()
    {
        return $"{GetGoalType()}|{GetGoalPoints()}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalCompleted()}|{_goalTotalPoints}|{_currentTimesGoal}|{_bonusRequiredTimes}|{_bonusPoints}";
    }

    public override void Deserialize(string[] part)
    {
        SetGoalType(part[0]);
        SetGoalPoints(int.Parse(part[1]));
        SetGoalName(part[2]);
        SetGoalDescription(part[3]);
        SetGoalCompleted(bool.Parse(part[4]));
        SetTotalGoalPoints(int.Parse(part[5]));
        _currentTimesGoal = int.Parse(part[6]);
        _bonusRequiredTimes = int.Parse(part[7]);
        _bonusPoints = int.Parse(part[8]);
    }
}
