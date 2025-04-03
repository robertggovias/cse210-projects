class Lectures : Event
{
    private string _speaker;
    private int _eventCapacity;

    public Lectures(string eventTitle, string description, DateTime date, DateTime time, Address address,string speaker, int eventCapacity,string eventType = "Lecture")
        : base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _eventCapacity = eventCapacity;
    }

    override public string MessageFullDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return $"\n--------------------------\nFull details\n--------------------------\n{MessageStandardDetails()}\nSpeaker: {_speaker}\nMax Capacity: {_eventCapacity} attendees";
    }
        
        
    }