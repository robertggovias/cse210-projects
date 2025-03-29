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

    public bool CustomerLiveUSA() 
    {
        return _address.AddressFromUSA(); // Verificar si el cliente vive en USA
    }
}