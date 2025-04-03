class Swimming : Activity
{
    public int _numberLaps;
    private double _lengthLapKm;

    public Swimming(
        DateTime date,
        int timeMinutes,
        int numberLaps,
        string typeActivity = "Swimming"
    )
        : base(date, timeMinutes, typeActivity)
    {
        _numberLaps = numberLaps;
        _lengthLapKm = _numberLaps * 50 / 1000;
    }

    public override double GetDistance()
    {
        return _numberLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        return _timeMinutes / _lengthLapKm;
    }
}
