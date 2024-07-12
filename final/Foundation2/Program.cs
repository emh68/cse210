using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("15336 S Oriskany Ln", "Draper", "UT", "USA");
        Address address2 = new Address("127 Oakwood Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Richard Willmore", address1);
        Customer customer2 = new Customer("Barbara Foster", address2);

        Product product1 = new Product("Dell Latitude 3400 Laptop", "1tle34ag", 1258.59m, 1);
        Product product2 = new Product("6TB SSD Hard Drive", "2pn52qn15", 422.45m, 1);
        Product product3 = new Product("512GB Thumb Drive", "1m3qtr46", 24.99m, 3);
        Product product4 = new Product("65\" QLED Samsung TV", "x25np65", 2999.99m, 1);

        List<Product> productsOrder1 = new List<Product> { product1, product2, product3 };
        List<Product> productsOrder2 = new List<Product> { product3, product4 };

        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsOrder2, customer2);

        Console.WriteLine("Order 1 Packing Slip:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Cost: ${order1.CalculateOrderTotal()}");

        Console.WriteLine("\nOrder 2 Packing Slip:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Cost: ${order2.CalculateOrderTotal()}");
    }
}