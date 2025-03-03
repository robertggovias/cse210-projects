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

    public void Breathing(string Breath/* , int time */)
    {
        Console.Write(Breath);
        //CountDown(time);
        
        //Console.WriteLine("\n");
    }

    public string GetInhalationMessage()
    {
        return _inhalationMessage;
    }

    public string GetExahalationMessage()
    {
        return _exahalationMessage;
    }
    //This stretch goal is for animation that emulates breathing. but to be honest I sacrficated a good logic that determinates how much time for inhaltes and exalates, I comented them, becaues I prefer them as showing the porwer of inheritance
    public void BarAnimationInhalate(){
        Console.CursorVisible = false;
        Console.Write("1 ▓");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b\b \b");
        Console.Write("2 ▓▒");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b\b \b\b \b");
        Console.Write("3 ▓▒░\n\n");
        Thread.Sleep(1000);
        Console.CursorVisible = true;
    }
    public void BarAnimationExhalate(){
        Console.CursorVisible = false;        
        Console.Write("3 ▓▒░");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b\b \b\b \b\b \b");
        Console.Write("2 ▓▒");
        Thread.Sleep(1000);
        Console.Write("\b \b\b \b\b \b\b \b");
        Console.Write("1 ▓\n\n");        
        Thread.Sleep(1000);
        Console.CursorVisible = true;
    }
}
