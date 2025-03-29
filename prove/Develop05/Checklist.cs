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
        int bonusRequiredTimes)
        : base(goalCounter, goalPoints, goalName, goalDescription, goalCompleted)
    {
    
        _currentTimesGoal = currentTimesGoal;
        _bonusRequiredTimes = bonusRequiredTimes;
        _bonusPoints = bonusPoints;
        
    }

    public void NewGoal(ChecklistGoal goal)
    {
        Console.WriteLine("Which type of goal would you like to create?");
        goal._goalPoints = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?");
        goal._goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        goal._goalDescription = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        goal._goalPoints = int.Parse(Console.ReadLine());

        Console.WriteLine("How many times does this goal need to be accomlished for a bonus?");
        goal._bonusRequiredTimes = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        goal._bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent() { }

    public override void DisplayGoal()
    {
        Console.WriteLine(
            $"{_goalCounter}. {CheckBox()} {_goalName} ({_goalDescription}), point per goal {_goalPoints} cuanto tengo {_currentTimesGoal} / cuantos necesito {_bonusRequiredTimes}, cuanto ganaré {_bonusPoints}"
        );
    }
}
