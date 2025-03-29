public class Order
{
    private List<Product> _listProduct;
    private List<Customer> _listCustomer;
    private int _shippingCostInUSA;
    private int _shippingCostOutUSA;

    public Order(List<Product> listProduct, List<Customer> listCustomer)
    {
        _listProduct = listProduct;
        _listCustomer = listCustomer;
    }

    public void SetShippingCostsInOut() 
    {
        // Implementación para establecer los costos de envío dentro y fuera de USA
    }

    public int ProductsCostTotal() 
    {
        // Implementación para obtener el costo total de los productos
        return 0; // Devolver el total calculado
    }

    public int ShippingCost() 
    {
        // Implementación para obtener el costo de envío
        return 0; // Devolver costo de envío calculado
    }

    public int TotalCostOrder() 
    {
        // Implementación para calcular el costo total del pedido
        return 0; // Devolver costo total calculado
    }

    public void PackingLabel() 
    {
        // Implementación para generar la etiqueta de embalaje
    }

    public void ShippingLabel() 
    {
        // Implementación para generar la etiqueta de envío
    }
}
