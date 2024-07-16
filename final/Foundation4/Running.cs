public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, int duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public void SetDistance(float distance)
    {
        _distance = distance;
    }

    public override float GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }

    public override float GetPace()
    {
        return GetDuration() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} Running ({GetDuration()} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}