using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Cycling cycling = new Cycling(new DateTime(2025, 5, 5), 60, 1);
        Running running = new Running(new DateTime(2025, 5, 5), 60, 1);
        Swimming swimming = new Swimming(new DateTime(2025, 5, 5), 60, 20);
        Console.WriteLine(swimming._numberLaps);

        activities.Add(cycling);
        activities.Add(running);        
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
