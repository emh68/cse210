public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public TimeSpan GetTime()
    {
        return _time;
    }

    public void SetTime(TimeSpan time)
    {
        _time = time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{_eventTitle}\n{_description}\n{_date.ToShortDateString()} {_time}\n{_address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"{_eventTitle} on {_date.ToShortDateString()}\n{GetType().Name}";
    }
}