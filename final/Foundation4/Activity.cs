abstract class Activity
{
    protected DateTime _date;
    protected double _timeMinutes;
    private double _hours;
    protected string _typeActivity;

    public Activity(DateTime date, double timeMinutes, string typeActivity)
    {
        _date = date;
        _timeMinutes = timeMinutes;
        _hours = timeMinutes / 60;
        _typeActivity = typeActivity;
    }

    public double GetHours()
    {
        return _hours;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return GetDistance() / _hours;
    }

    public virtual double GetPace()
    {
        return _timeMinutes / GetDistance();
        ;
    }

    public string GetSummary()
    {
        return $"- {_date.Date.ToString("dd, MMMM yyyy")} {_typeActivity} ({_timeMinutes} min): Distance {Math.Round(GetDistance(), 4).ToString("G")} km ({Math.Round(GetDistance() * 1000, 1).ToString("G")} m), Speed {Math.Round(GetSpeed(), 4).ToString("G")} km/h, Pace {Math.Round(GetPace(), 4).ToString("G")} min per km";
    }
}
