public class Bike : Activity
{
    private float _speed;

    public Bike(DateTime date, int duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * (GetDuration() / 60);
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} Cycling ({GetDuration()} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}