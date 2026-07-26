using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 850.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P102", 25.00, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 45.00, 1));

        // Order 2 (International)
        Address address2 = new Address(
            "15 Marina Road",
            "Lagos",
            "Lagos",
            "Nigeria");

        Customer customer2 = new Customer("Benjamin Ewoh", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P201", 220.00, 2));
        order2.AddProduct(new Product("USB Drive", "P202", 15.00, 4));

        DisplayOrder(order1);

        Console.WriteLine("----------------------------------------");

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order.CalculateTotalCost():F2}");
        Console.WriteLine();
    }
}