using System;

class Program
{
    static void Main(string[] args)
    {

    // Create addresses    
    Address address1 = new Address("Anne St. #25238", "Provo", "Utah", "United States");
    Address address2 = new Address("Main St. #65677", "Providence", "Rhode Island", "United States");
    Address address3 = new Address("Vitacura #15100", "Santiago", "Region Metropolitana", "Chile");

    // Create customers
    Customer customer1 = new Customer("George Washington", address1);
    Customer customer2 = new Customer("Jim Carrey", address2);
    Customer customer3 = new Customer("Miguel Villa", address3);

    // Create products
    Product p1 = new Product("Lenovo 14\" Laptop", "LAP-1001", 549.99m, 1);
    Product p2 = new Product("Logitech Mouse", "MOU-2034", 24.99m, 2);
    Product p3 = new Product("Redragon Mechanical Keyboard", "KEY-1188", 49.99m, 1);
    Product p4 = new Product("Samsung 27\" Monitor", "MON-3302", 199.99m, 1);
    Product p5 = new Product("Sony Bluetooth Headphones", "AUD-4520", 89.99m, 3);
    Product p6 = new Product("Anker USB-C Charger", "CHA-5501", 19.99m, 4);
    Product p7 = new Product("20,000mAh Power Bank", "POW-2210", 39.99m, 2);
    Product p8 = new Product("Android 10\" Tablet", "TAB-9005", 159.99m, 1);
    Product p9 = new Product("Xiaomi Smartwatch", "SMA-7800", 69.99m, 1);

    // Create lists of products
    List<Product> list1 = new List<Product>(){p1, p2, p3};
    List<Product> list2 = new List<Product>(){p4, p5, p6};
    List<Product> list3 = new List<Product>(){p7, p8, p9};

    // Create orders
    Order order1 = new Order(list1, customer1);
    Order order2 = new Order(list2, customer2);
    Order order3 = new Order(list3, customer3);

    // Display orders information
    Console.WriteLine("################### ORDER 1 ###################");
    order1.DisplayOrderInfo();
    Console.WriteLine("################### ORDER 2 ###################");
    order2.DisplayOrderInfo();
    Console.WriteLine("################### ORDER 3 ###################");
    order3.DisplayOrderInfo();



    }
}