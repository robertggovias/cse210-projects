class Swimming : Activity
{
    public double _numberLaps;
    private double _lengthLapKm;

    public Swimming(
        DateTime date,
        double timeMinutes,
        double numberLaps,
        string typeActivity = "Swimming"
    )
        : base(date, timeMinutes, typeActivity)
    {
        _numberLaps = numberLaps;
        _lengthLapKm = _numberLaps * 50.0 / 1000.0;
    }

    public override double GetDistance()
    {
        return _numberLaps * 50.0 / 1000.0;
    }

    public override double GetPace()
    {
        return _timeMinutes / _lengthLapKm;
    }
}
