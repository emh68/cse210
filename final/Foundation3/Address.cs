public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _street = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetZip()
    {
        return _zip;
    }

    public void SetZip(string zip)
    {
        _zip = zip;
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_zip}";
    }

}