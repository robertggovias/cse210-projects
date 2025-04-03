class Event
{

    private string _eventType;
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string eventType, string eventTitle, string description, DateTime date, DateTime time, Address address)
    {
        
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        Console.ForegroundColor = ConsoleColor.White;
    }

    public string MessageShortDescription() 
    {        
        Console.ForegroundColor = ConsoleColor.Green;
    return $"Short description\n--------------------------\nEvent type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date.Date.ToString("MMMM d, yyyy")}";
        
        
    }

    public string MessageStandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.Date.ToString("MMMM d, yyyy")}\nTime: {_time.ToString("HH:mm tt")}\n{_address.DisplayAddress()}";
        
    }
    public string TypeOfEvent()
    {
        return $"Event Type:{_eventType}\n";
    }
    virtual public string MessageFullDetails()
    { return ""; }

    
}
    