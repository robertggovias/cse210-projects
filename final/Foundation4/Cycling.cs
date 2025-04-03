class Cycling : Activity
{
    private double _speedKmH;    
    

    public Cycling(DateTime date, int timeMinutes, double speedKmH, string typeActivity = "Cycling")
        : base(date, timeMinutes, typeActivity)
    {
        _speedKmH = speedKmH;
    }    

    public override double GetDistance()
    {
        return _speedKmH * GetHours();
    }
}
