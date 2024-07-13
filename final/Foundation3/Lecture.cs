public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nSpeaker Name: {_speakerName}\nCapacity: {_capacity}";
    }
}