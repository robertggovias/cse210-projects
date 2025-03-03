using System.Diagnostics.Contracts;

class BreathingActivity : Activity
{
    private string _inhalationMessage;
    private string _exahalationMessage;

    public BreathingActivity(
        string activityName,
        string activityDescription,
        int activityDuration,
        string inhalationMessage,
        string exahalationMessage
    )
        : base(activityName, activityDescription, activityDuration)
    {
        _inhalationMessage = inhalationMessage;
        _exahalationMessage = exahalationMessage;
    }

    public void Breathing(string Breath, int time)
    {
        Console.Write(Breath);
        CountDown(time);
        Console.WriteLine("\n");
    }

    public string GetInhalationMessage()
    {
        return _inhalationMessage;
    }

    public string GetExahalationMessage()
    {
        return _exahalationMessage;
    }
}