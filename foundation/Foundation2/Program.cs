using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Create addresses
        Address address1 = new Address("50 N Temple", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("9900 Stoneybrook Dr", "Kensington", "MD", "USA");
        Address address3 = new Address("Av. Prof. Francisco Morato, 2390", "Caxingui", "SP", "BRA");

        // Create customers
        Customer customer1 = new Customer("David A. Bednar", address1);
        Customer customer2 = new Customer("Steven Robeck", address2);
        Customer customer3 = new Customer("Rodrigo Catingueira", address3);

        // Create products
        Product product1 = new Product("Chromebook 14", "LAP014", (decimal)799.95, 12);
        Product product2 = new Product("Wired Mouse", "MOU001", (decimal)12.99, 15);
        Product product3 = new Product("DELL Keyboard", "KEY779", (decimal)22.50, 10);
        Product product4 = new Product("DELL Monitor", "MON101", (decimal)199.99, 20);
        Product product5 = new Product("Wireless Headphones", "HEA010", (decimal)59.99, 16);
        Product product6 = new Product("Laptop Case", "CAS301", (decimal)9.99, 12);
        Product product7 = new Product("Line Filter", "LIN532", (decimal)19.25, 20);
        Product product8 = new Product("External Hard Drive", "DRI444", (decimal)49.99, 10);
        Product product9 = new Product("Webcam", "WEB043", (decimal)23.89, 12);
        Product product10 = new Product("HDMI Cable", "CAB231", (decimal)9.99, 18);


        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product5);
        order1.AddProduct(product9);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        order2.AddProduct(product8);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product6);
        order3.AddProduct(product10);

        // Display details for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.ComputeTotalCost()}\n");

        // Display details for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.ComputeTotalCost()}\n");

        // Display details for order3
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: {order3.ComputeTotalCost()}\n");
        
    }
}
