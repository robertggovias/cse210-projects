public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public Address GetAddressDetails() 
    {
        // Implementación para obtener los detalles de la dirección
        return this; // Devolver detalles de la dirección actual
    }

    public bool AddressFromUSA() 
    {
        // Implementación para verificar si la dirección es de USA
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
}