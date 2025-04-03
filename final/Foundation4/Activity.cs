abstract class Activity
{
    protected DateTime _date;
    protected int _timeMinutes;
    private double _hours;
    protected string _typeActivity;

    public Activity(DateTime date, int timeMinutes, string typeActivity)
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
        return Math.Round(_timeMinutes / GetDistance(),2);
        ;
    }

    public string GetSummary()
    {
        return $"\n- {_date.Date.ToString("dd, MMMM yyyy")} {_typeActivity} ({_timeMinutes} min): Distance {GetDistance()} km ({GetDistance()*1000} m), Speed {GetSpeed()} km/h, Pace {GetPace()} min per km";
    }
}
