using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Cycling cyclingLikeRookie = new Cycling(new DateTime(2025, 5, 5), 90, 25);
        Cycling cyclingLikePro = new Cycling(new DateTime(2025, 5, 6), 120, 30);
        Cycling cyclingLikeOlimpic = new Cycling(new DateTime(2025, 5, 7), 60, 56.792);

        Running runningLikeRookie = new Running(new DateTime(2025, 6, 8), 30, 5000);
        Running runningLikePro = new Running(new DateTime(2025, 6, 9), 50, 10000);
        Running runningLikeOlimpic = new Running(new DateTime(2025, 6, 10), 120, 42195);

        Swimming swimmingLikeRookie = new Swimming(new DateTime(2025, 7, 11), 15, 10);
        Swimming swimmingLikePro = new Swimming(new DateTime(2025, 7, 12), 20, 20);
        Swimming swimmingLikeOlimpic = new Swimming(new DateTime(2025, 7, 13), 15, 30);

        activities =
        [
            cyclingLikeRookie,
            cyclingLikePro,
            cyclingLikeOlimpic,
            runningLikeRookie,
            runningLikePro,
            runningLikeOlimpic,
            swimmingLikeRookie,
            swimmingLikePro,
            swimmingLikeOlimpic,
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
