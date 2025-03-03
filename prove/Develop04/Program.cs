using System;
using System.Collections.Specialized;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity(
            "Breathing Activity",
            "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            0,
            "Breathe in...",
            "Now breathe out..."
        );
        ReflectingActivity reflectingActivity = new ReflectingActivity(
            "Reflection Activity",
            "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            24,
            "Piensa en el dia que te pegaste en el dedo pequeño",
            "Pensaste en proferir alguna palabra profana?"
        );
        ListingActivity listing_Activity = new ListingActivity(
            "Listing Activity",
            "reflect on the good things in your life by having you list as many things as you can in a certain area.",
            2434,
            "Pregunta",
            "respuesta"
        );

        int answer;

        do
        {
            activity.Menu();
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    breathingActivity.Intro();
                    breathingActivity.setEndTime(breathingActivity.getDuration());

                    while (DateTime.Now < breathingActivity.getEndTime())
                    {
                        breathingActivity.Breathing(breathingActivity.GetInhalationMessage(), 3);
                        breathingActivity.Breathing(breathingActivity.GetExahalationMessage(), 3);
                    }
                    breathingActivity.EndActivity(5);
                    break;
                case 2:
                    reflectingActivity.ShuflePhrases(reflectingActivity.reflectionMessage());
                    reflectingActivity.ShuflePhrases(reflectingActivity.reflectionQuestion());
                    int i = 0;
                    reflectingActivity.Intro();
                    Console.WriteLine(
                        $"Consider the following prompt:\n---{reflectingActivity.getListElem(reflectingActivity.reflectionMessage(), 0)}---\n When you have something in mind, press enter to continue."
                    );
                    Console.ReadLine();
                    Console.WriteLine(
                        "Now ponder on each of the following questions as they related to this experience.\n"
                    );
                    Console.WriteLine("You may begin in: ");
                    reflectingActivity.CountDown(5);
                    reflectingActivity.setEndTime(reflectingActivity.getDuration());
                    while (DateTime.Now < reflectingActivity.getEndTime())
                    {
                        Console.Write(
                            $"\n{reflectingActivity.getListElem(reflectingActivity.reflectionQuestion(), i)} "
                        );
                        reflectingActivity.Spinner(3);
                        Console.WriteLine("\n");
                        i++;
                    }
                    reflectingActivity.EndActivity(5);
                    break;

                case 3:
                    listing_Activity.Intro();
                    listing_Activity.ShuflePhrases(listing_Activity.ListingQuestions());
                    int z = 0;
                    Console.WriteLine(
                        $"List as many responses you can to the following prompt: \n---{listing_Activity.getListElem(listing_Activity.ListingQuestions(), z)}---"
                    );
                    Console.WriteLine("You may begin in: ");
                    reflectingActivity.CountDown(5);
                    listing_Activity.setEndTime(listing_Activity.getDuration());
                    while (DateTime.Now < listing_Activity.getEndTime())
                    {
                        Console.Write("> ");
                        string _answer = Console.ReadLine();
                       listing_Activity.AddListingAnswers(_answer);                                                
                    }
                    Console.WriteLine($"You listed {listing_Activity.ListingAnswers().Count}");
                    listing_Activity.EndActivity(5);
                    break;
            }
        } while (answer != 4);

        //reflectingActivity.EndActivity();
        /*    breathingActivity.EndActivity();
           listing_Activity.EndActivity();
           reflectingActivity.Spinner(10);
           
           reflectingActivity.CountDown(5);
           reflectingActivity.CountingTimeTest(4); */
    }
}
