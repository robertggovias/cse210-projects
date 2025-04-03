class Receptions : Event
{
    private string _rSVPEmail;

    public Receptions(string eventTitle, string description, DateTime date, DateTime time, Address address,string rSVPEmail, string eventType= "Reception")
        : base(eventType, eventTitle, description, date, time, address)
    {
        _rSVPEmail = rSVPEmail;
    }
    
    


    override public string MessageFullDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return $"\n--------------------------\nFull details\n--------------------------\n{TypeOfEvent()}{MessageStandardDetails()}\nRSVP Email: {_rSVPEmail}";
    }
       
    }
