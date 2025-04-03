using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTimeEvent1 = new DateTime(2025, 4, 10, 14,00,00);
        DateTime dateTimeEvent2 = new DateTime(2025, 5, 15, 11,00,00);
        DateTime dateTimeEvent3 = new DateTime(2025, 6, 5, 19,00,00);        
        

        string _sM =
            "\n--------------------------\nStandard details:\n--------------------------\n";

        List<Event> events = new List<Event>();

        Lectures lectures = new Lectures(
            "Advances in Artificial Intelligence",
            "A talk about AI's impact on various industries.",
            dateTimeEvent1,
            dateTimeEvent1,
            new Address("123 Tech Avenue", "San Francisco", "CA"),
            "Dr. Alan Turing",
            200
        );

        OutdoorsGatherings outdoorsGatherings = new OutdoorsGatherings(
            "Community Picnic",
            "An outdoor event to enjoy with family and friends.",
            dateTimeEvent2,
            dateTimeEvent2,
            new Address("Central Park", "New York", "NY"),            
            "Sunny with a light breeze."
        );
        


        Receptions receptions = new Receptions(
            "Annual Charity Gala",
            "An exclusive event to raise funds for charity.",
            dateTimeEvent3,
            dateTimeEvent3,
           new Address("Ritz Hotel", "Los Angeles", "CA"),
            "contact@event.com"
        );
        events.Add(lectures);
        events.Add(outdoorsGatherings);
        events.Add(receptions);

        void DisplayAllEvents()
        {
            
            Console.WriteLine("Marketing event details: \n\n");
            int count = 0;
            foreach (Event e in events)
            {
                count++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(
                    $"===========================\nEvent {count}:\n===========================\n"
                );
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.MessageShortDescription());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{_sM}{e.MessageStandardDetails()}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{e.MessageFullDetails()}\n\n");
            }
        }
        DisplayAllEvents();
    }
}
