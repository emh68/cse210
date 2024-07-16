public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int duration, int numberOfLaps) : base(date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }

    public void SetNumberOfLaps(int numberOfLaps)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return _numberOfLaps * 50 / 1000f * 0.62f;
    }
    public override float GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
    public override float GetPace()
    {
        return GetDuration() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} Swimming ({GetDuration()} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}