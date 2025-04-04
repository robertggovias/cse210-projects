class Receptions : Event
{
    private string _rSVPEmail;

    public Receptions(
        string eventTitle,
        string description,
        DateTime date,
        DateTime time,
        Address address,
        string rSVPEmail,
        string eventType = "Reception"
    )
        : base(eventType, eventTitle, description, date, time, address)
    {
        _rSVPEmail = rSVPEmail;
    }

    //I understand that this project is focused on inheritance, but overriding this method allowed me to iterate and participate in all events. I tried other options, but they didn't work. But I can change it if necessary.
    public override string MessageFullDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        return $"\n--------------------------\nFull details\n--------------------------\n{TypeOfEvent()}{MessageStandardDetails()}\nRSVP Email: {_rSVPEmail}";
    }
}
