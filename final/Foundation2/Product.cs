public class Product
{
    private string _name;
    private int _productID;
    private int _pricePerUnit;
    private int _quantityProducts;

    public Product(string name, int productID, int pricePerUnit, int quantityProducts)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantityProducts = quantityProducts;
    }

    public Product GetProductDetails() 
    {
        // Implementación para obtener los detalles del producto
        return this; // Devolver detalles del producto actual
    }

    public int TotalCostProducts() 
    {
        // Implementación para calcular el costo total de los productos
        return _pricePerUnit * _quantityProducts; // Devolver costo total calculado
    }
}