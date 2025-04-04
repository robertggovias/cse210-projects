using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _listProduct;

    private int _shippingCostInUSA = 5;
    private int _shippingCostOutUSA = 35;

    private Customer _customer;
    private Product _product;

    public string ShippingLabel()
    {
        return _customer.CustomerDetailForLabel();
    }

    public string CustomerDetails()
    {
        return _customer.CustomerDetailForOrder();
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _listProduct)
        {
            Console.WriteLine(product.OneProductDetailsOnLabel());
        }
    }

    public Order(List<Product> listProduct, Customer customer)
    {
        _listProduct = listProduct;
        _customer = customer;
    }

    public void AddNewProduct(Product product)
    {
        _listProduct.Add(product);
    }

    public void SetShippingCostsInUSA(int price)
    {
        _shippingCostInUSA = price;
    }

    public void SetShippingCostsOutUSA(int price)
    {
        _shippingCostOutUSA = price;
    }

    public double ProductsCostTotal()
    {
        double productCostTotal = 0;
        foreach (Product product in _listProduct)
        {
            productCostTotal += product.TotalCostProducts();
        }
        return productCostTotal;        
    }

    public int ShippingCost()
    {
        int shippingCost;
        if (_customer.CustomerLiveUSA() == true)
        {
            shippingCost = _shippingCostInUSA;
        }
        else
        {
            shippingCost = _shippingCostOutUSA;
        }        
        return shippingCost;
    }

    public double TotalCostOrder()
    {
        ShippingCost();
        return ShippingCost() + ProductsCostTotal();
    }

    public void OrderComplete()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(CustomerDetails());
        Console.ForegroundColor = ConsoleColor.Magenta;
        PackingLabel();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{ShippingLabel()}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"\n\nOrder Total: ${TotalCostOrder()}\n(Product Total: ${ProductsCostTotal()} + Shipping: ${ShippingCost()})\n"
        );
        Console.ForegroundColor = ConsoleColor.White;
    }
}
