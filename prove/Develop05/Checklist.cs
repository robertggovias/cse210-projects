 public class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;

        public ChecklistGoal(int points, bool goalComplete, string goalName, string goalDescription, int targetCount)
            : base(points, goalComplete, goalName, goalDescription)
        {
            _targetCount = targetCount;
            _currentCount = 0;
        }

        public override void NewGoal()
        {
            Console.WriteLine("Creating a new Checklist Goal.");
        }

        public override bool CheckBox()
        {
            return _goalComplete;
        }

        public override void RecordEvent()
        {
           
        }

        public override void DisplayGoal()
        {
            Console.WriteLine($"Goal: {_goalName}, Description: {_goalDescription}, Points: {_points}, Completed: {_goalComplete}, Progress: {_currentCount}/{_targetCount}");
        }
    }