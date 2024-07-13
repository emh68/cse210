public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather: {_weather}";
    }
}