using System.Data;
using System.Diagnostics.Contracts;

class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    private List<int> _aleatoryList;

    private DateTime _activityEndTime;
    public List<string> _group;

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityDuration = activityDuration;
        //_group = new List<string>{activityName,activityDescription,introduction_message};
    }

    public Activity() { }

    public void descriptionWrite()
    {
        Console.WriteLine(_activityDescription);
    }

    public void askDuration()
    {
        Console.WriteLine(
            $"How long, in seconds, would you like for your session in {_activityName}?"
        );
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public int getDuration()
    {
        return _activityDuration;
    }

    public string Welcome()
    {
        return "Welcome to the " + _activityName + ".";
    }

    public string Description()
    {
        return "This activity will help you " + _activityDescription;
    }

    public void Intro()
    {
        Console.WriteLine($"{Welcome()} \n \n {Description()}");
        askDuration();
        Console.Clear();
        GetReady(5);
    }

    public int SecondToMili(int miliSeconds)
    {
        return miliSeconds * 1000;
    }

    public void Spinner(int wait)
    {
        Console.CursorVisible = false;
        int timelong = SecondToMili(wait);
        int fPs = 1000 / 8;
        do
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("|");
            Thread.Sleep(fPs);
            Console.Write("\b \b");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("/");
            Thread.Sleep(fPs);
            Console.Write("\b \b");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("-");
            Thread.Sleep(fPs);
            Console.Write("\b \b");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\\");
            Thread.Sleep(fPs);
            Console.Write("\b \b");

            timelong = timelong - (fPs * 4);
            //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        } while (timelong > 0);
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void GetReady(int spiner)
    {
        Console.WriteLine("Get ready...");
        Spinner(spiner);
    }

    public void WellDone(int spiner)
    {
        Console.WriteLine("\nWell done!!");
        Spinner(spiner);
    }

    public void EndActivity(int spiner)
    {
        WellDone(3);
        Console.WriteLine(
            $"\n You have completed another {_activityDuration} seconds of the {_activityName}."
        );
        Spinner(spiner);
    }

    public DateTime Seconds(int seconds)
    {
        DateTime agora = DateTime.Now;
        return agora.AddSeconds(seconds);
    }

    public DateTime setEndTime(int seconds)
    {
        DateTime rigthNow = DateTime.Now;
        _activityEndTime = rigthNow.AddSeconds(seconds);
        return _activityEndTime;
    }

    public DateTime getEndTime()
    {
        return _activityEndTime;
    }

    public void CountDown(int time)
    {
        Console.CursorVisible = false;
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }

    public void CountingTimeTest(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = time;
        while (DateTime.Now < endTime)
        {
            Console.Write(i);
            i++;
            Thread.Sleep(1000);
            //Console.Write("\b \b");
            /* Console.WriteLine("tiempo de ahora " + startTime.ToString());
            Console.WriteLine("tiempo DateTime.Now " + startTime.ToString());
            Console.WriteLine("tiempo de final " + endTime.ToString()); */
        }
    }

    /* public void CountDownPause(int time){
        private int _time = time;

    } */

    /*   public void WaitingAnimation(int time){
      private int _time = time;

  } */
    public void Menu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Menu Options:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
            " 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity"
        );
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 4.  How many activities did I completed so far?");
        Console.WriteLine(" 5.  How much time did you completed so far?");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 6. Quit");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void ShuflePhrases(List<string> listToShufle)
    {
        int finalPrompt = listToShufle.Count() - 1;
        while (finalPrompt > 0)
        {
            string temporalPropmt = listToShufle[finalPrompt];
            int randomPrompt = new Random().Next(0, finalPrompt);
            listToShufle[finalPrompt] = listToShufle[randomPrompt];
            listToShufle[randomPrompt] = temporalPropmt;
            finalPrompt--;
        }
    }
}
