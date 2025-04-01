public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer GetCustomerDetails()
    {
        // Implementación para obtener los detalles del cliente
        return this; // Devolver detalles del cliente actual
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string CustomerDetailForLabel()
    {
        return $"Shipping Label\n Name: {_name}\n Address:\n{_address.GetAddressDetails()}";
    }

    public string CustomerDetailForOrder()
    {
        return $"Customer Details\n Name: {_name}\n Shipping Address:\n{_address.GetAddressDetails()}\n";
    }

    public bool CustomerLiveUSA()
    {
        return _address.GetIfUSA();
    }
}
