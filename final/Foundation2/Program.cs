using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine();

        Product p1 = new Product("Iphone 15", 111, 1300, 10);
        Product p2 = new Product("Samsung S23 ultra", 112, 1000, 5);
        List<Product> product1 = new List<Product> { p1, p2 };

        Product p3 = new Product("M2 MacBook Air 15-inch", 113, 1700, 10);
        Product p4 = new Product("HP Pavilion Plus 14", 114, 1400, 20);
        List<Product> product2 = new List<Product> { p3, p4 };

        Address a1 = new Address("WINGET", "ADDIS ABABA", "ADDIS ABABA", "ETHIOPIA");
        Address a2 = new Address("8407 QUINTANA STREET", "NEW CARROLLTON", "MARYLAND", "USA");

        Customer c1 = new Customer();
        c1.SetCustomerName("Natanel");
        c1.SetCustomerAddress(a1);

        Customer c2 = new Customer();
        c2.SetCustomerName("Daniel");
        c2.SetCustomerAddress(a2);

        Order order1 = new Order(product1, c1);
        Order order2 = new Order(product2, c2);

        Console.WriteLine("Customer Information");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine("List of Products");
        Console.WriteLine($"{order1.PackagingLabel()}");
        Console.WriteLine($"{order1.GetTotalPrice()}");

        Console.WriteLine();

        Console.WriteLine("Customer Information");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine("List of Products");
        Console.WriteLine($"{order2.PackagingLabel()}");
        Console.WriteLine($"{order2.GetTotalPrice()}");
    }
}