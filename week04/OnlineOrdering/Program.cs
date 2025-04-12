using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - US Customer
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Pen", "P001", 1.5, 10));
        order1.AddProduct(new Product("Notebook", "N001", 3.0, 5));

        // Order 2 - International Customer
        Address address2 = new Address("99 Elm Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Marker", "M002", 2.0, 8));
        order2.AddProduct(new Product("Sketchpad", "S003", 5.0, 2));

        // Print order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        // Print order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
