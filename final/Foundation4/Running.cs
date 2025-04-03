class Running : Activity
{
    private double _distanceMeters;

    public Running(
        DateTime date,
        int timeMinutes,
        double distanceMeters,
        string typeActivity = "Running"
    )
        : base(date, timeMinutes, typeActivity)
    {
        _distanceMeters = distanceMeters;
    }

    public override double GetDistance()
    {
        return _distanceMeters/1000;        
    }
}
