class GoalManager
{
    public Goal goal = new Goal();

    public int SumTotalPoints()
    {
        goal.SetPoints(45);
        return goal.getPoints();
    }

    private List<Goal> _goalList;

    public GoalManager()
    {
        
    }

    public void AddGoalToList(Goal goal)
    {
        
    }

    public void DisplayPoints() { }

    public void ListGoals() { }

    public void SaveGoals() { }

    public List<Goal> LoadGoals()
    {
        return _goalList;
    }
}
