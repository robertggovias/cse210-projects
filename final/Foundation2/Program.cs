using System;

class Program
{
    static void Main(string[] args)
    {
        List<Customer> newCustomers = new List<Customer>();
        List<Order> newOrders = new List<Order>();
        List<Order> products = new List<Order>();
        Address address = new Address("123 Temple Square", "Salt Lake City", "UT", "USA", true);
        Customer customer = new Customer("Liam Smith", address);

        Address address2 = new Address("518 Oswaldo Cruz", "Canoas", "RS", "Brazil", false);
        Customer customer2 = new Customer("Robert Govia", address2);

        Product product = new Product("Microscope", "A1013", 1400, 2);
        Product product_a = new Product("Telescope", "A1012", 1500.3, 4);
        Product product2 = new Product("Particle accelerator", "X0001", 450400, 1);
        Product product_a2 = new Product("Neutrino detector", "Y0001", 2541500, 2);
        Product product_a3 = new Product("Neodimium magnet", "Z0001", 5, 100);

        Order order1 = new Order([], customer);
        Order order2 = new Order([], customer2);

        order1.AddNewProduct(product);
        order1.AddNewProduct(product_a);
        order2.AddNewProduct(product2);
        order2.AddNewProduct(product_a2);
        order2.AddNewProduct(product_a3);
        newOrders.Add(order1);
        newOrders.Add(order2);
        newCustomers.Add(customer);
        newCustomers.Add(customer2);

        void PrintOrders()
        {
            int i = 0;
            Console.WriteLine(
                "=================================\nOrder Details\n=================================\n"
            );
            foreach (Order order in newOrders)
            {
                i++;
                Console.WriteLine($"Order #{i}");
                order.OrderComplete();
                Console.WriteLine("\n-----------------------------------------\n\n");
            }
        }
        PrintOrders();

        // Implementación del menú
    }
}
