class OutdoorsGatherings : Event
{
    private string _weatherForecast;
    

    public OutdoorsGatherings(string eventTitle, string description, DateTime date, DateTime time, Address address, string weatherForecast, string eventType = "Outdoors Gathering")
        : base(eventType, eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    override public string MessageFullDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return $"\n--------------------------\nFull details\n--------------------------\n{MessageStandardDetails()}\n{Console.ForegroundColor = ConsoleColor.Red}Weather Forecast: {Console.ForegroundColor = ConsoleColor.Cyan}{_weatherForecast}";
    }
        
    
}