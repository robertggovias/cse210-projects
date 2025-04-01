public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _isUSA;

    public Address(
        string streetAddress,
        string city,
        string stateProvince,
        string country,
        bool isUSA
    )
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _isUSA = isUSA;
    }

    public string GetAddressDetails()
    {
        return $"   Street: {_streetAddress}\n   {_city}, {_stateProvince}, {_country}";
    }

    public bool GetIfUSA()
    {
        return _isUSA;
    }
}
