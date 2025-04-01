public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantityProducts;

    public Product(string name, string productID, double pricePerUnit, int quantityProducts)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantityProducts = quantityProducts;
    }

    public string OneProductDetailsOnLabel()
    {
        return $"   - {_name} ({_productID})";
    }

    public double TotalCostProducts()
    {
        // Implementación para calcular el costo total de los productos
        return _pricePerUnit * _quantityProducts; // Devolver costo total calculado
    }
}
