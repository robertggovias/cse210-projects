class OutdoorsGatherings : Event
{
    private string _weatherForecast;

    public OutdoorsGatherings(
        string eventTitle,
        string description,
        DateTime date,
        DateTime time,
        Address address,
        string weatherForecast,
        string eventType = "Outdoors Gathering"
    )
        : base(eventType, eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    //I understand that this project is focused on inheritance, but overriding this method allowed me to iterate and participate in all events. I tried other options, but they didn't work. But I can change it if necessary.
    public override string MessageFullDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return $"\n--------------------------\nFull details\n--------------------------\n{MessageStandardDetails()}\n{Console.ForegroundColor = ConsoleColor.Red}Weather Forecast: {Console.ForegroundColor = ConsoleColor.Cyan}{_weatherForecast}";
    }
}
