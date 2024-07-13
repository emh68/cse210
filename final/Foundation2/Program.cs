using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("15336 S Oriskany Ln", "Draper", "UT", "USA");
        Address address2 = new Address("127 Oakwood Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("7821 Bluebell St", "Austin", "TX", "USA");
        Address address4 = new Address("45 Wellington St", "Ottawa", "ON", "Canada");
        Address address5 = new Address("321 Maple Dr", "Seattle", "WA", "USA");
        Address address6 = new Address("98 King St", "Sydney", "NSW", "Australia");

        Customer customer1 = new Customer("Richard Willmore", address1);
        Customer customer2 = new Customer("Barbara Foster", address2);
        Customer customer3 = new Customer("James Smith", address3);
        Customer customer4 = new Customer("Susan Johnson", address4);
        Customer customer5 = new Customer("Michael Brown", address5);
        Customer customer6 = new Customer("Emily Davis", address6);

        Product product1 = new Product("Dell Latitude 3400 Laptop", "1tle34ag", 1258.59m, 1);
        Product product2 = new Product("6TB SSD Hard Drive", "2pn52qn6tb", 422.45m, 1);
        Product product3 = new Product("512GB Thumb Drive", "1m3qtr512", 24.99m, 3);
        Product product4 = new Product("65\" QLED Samsung TV", "x25np65", 2999.99m, 1);
        Product product5 = new Product("Apple MacBook Pro 16\"", "mbp16a1", 2399.99m, 1);
        Product product6 = new Product("HP Envy Photo Printer", "hp567p", 199.99m, 1);
        Product product7 = new Product("Sony WH-1000XM4 Headphones", "sonyxm4", 349.99m, 1);
        Product product8 = new Product("Samsung Galaxy S21", "sgs21", 799.99m, 1);
        Product product9 = new Product("Asus ROG Gaming Laptop", "asusrog", 1599.99m, 1);
        Product product10 = new Product("Logitech MX Master 3 Mouse", "logimx3", 99.99m, 1);

        List<Product> productsOrder1 = new List<Product> { product1, product2, product3 };
        List<Product> productsOrder2 = new List<Product> { product3, product4 };
        List<Product> productsOrder3 = new List<Product> { product1, product6 };
        List<Product> productsOrder4 = new List<Product> { product5 };
        List<Product> productsOrder5 = new List<Product> { product2, product9, product10 };
        List<Product> productsOrder6 = new List<Product> { product7, product8 };

        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsOrder2, customer2);
        Order order3 = new Order(productsOrder3, customer3);
        Order order4 = new Order(productsOrder4, customer4);
        Order order5 = new Order(productsOrder5, customer5);
        Order order6 = new Order(productsOrder6, customer6);

        List<Order> orders = new List<Order>
        {
            order1,
            order2,
            order3,
            order4,
            order5,
            order6
        };

        for (int i = 0; i < orders.Count; i++)
        {
            Order order = orders[i];
            Console.WriteLine($"Order {i + 1} Packing Slip:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Shipping Cost: ${order.CalculateShippingCost():F2}");
            Console.WriteLine($"\nOrder {i + 1} Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nOrder {i + 1} Total Cost: ${order.CalculateOrderTotal():F2}");
            Console.WriteLine(new string('-', 30));
        }
    }
}