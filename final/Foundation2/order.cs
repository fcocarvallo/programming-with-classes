public class Order
{
    private Customer _customer;
    private List<Product> _productList= new List<Product>();

    public Order(List<Product> productList, Customer customer)
    {
        _customer = customer;
        _productList = productList;
    }

    private string GetCustomerName()
    {
        return _customer.GetName();
    }



    private string GetCustomerAddress()
    {
        return _customer.GetAddress().ShowAddress();
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach(Product product in _productList)
        {
            total = total + product.GetPrice() * product.GetQuantity();
        }

        if (_customer.GetAddress().IsLocal()){
        return total + 5;
        }
        else
        {
            return total + 35;
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("------ SHIPPING LABEL ------\n");

        Console.WriteLine("Recipient:");
        Console.WriteLine($"  {GetCustomerName()}");
        Console.WriteLine();

        Console.WriteLine("Address:");
        Console.WriteLine($"  {GetCustomerAddress()}");

        Console.WriteLine("\n----------------------------");
    }


    public void PackingLabel()
    {
        Console.WriteLine("------ PACKING LABEL ------\n");

        foreach (Product product in _productList)
        {
            Console.WriteLine($"Product: {product.GetName()}");
            Console.WriteLine($"SKU:     {product.GetId()}");
            Console.WriteLine($"Qty:     {product.GetQuantity()}");
            Console.WriteLine("------------------------------");
        }

        Console.WriteLine();
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("               ORDER SUMMARY");
        Console.WriteLine("========================================\n");

        PackingLabel();

        ShippingLabel();

        Console.WriteLine($"Order Total (incl. shipping):  ${CalculateTotal():0.00}");
        Console.WriteLine("========================================\n");
        Console.WriteLine($"Get 25% off in your next order with the code: {GetCustomerName()}-ILOVECHRISTMASS\n");
        Console.WriteLine("========================================\n");
    }

}