public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }
    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}
