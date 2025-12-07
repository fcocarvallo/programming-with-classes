public class Order
{
    private Customer _customer;
    private List<Product> _productList= new List<Product>();

    public Order(List<Product> productList, Customer customer)
    {
        _customer = customer;
        _productList = productList;
    }

    public string GetCustomerName()
    {
        return _customer.GetName();
    }



    public string GetCustomerAddress()
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
        Console.WriteLine($"Name: {GetCustomerName()}\nAddress: {GetCustomerAddress()}");
    }

    public void PackingLabel()
    {
        foreach(Product product in _productList)
        {
            Console.WriteLine($"{product.GetName()}\nSKU: {product.GetId()}");
            Console.WriteLine();
        }
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine("-------------------------------------------------");
        PackingLabel();
        Console.WriteLine("-------------------------------------------------");
         Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("-------------------------------------------------");
        ShippingLabel();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"TOTAL PRICE: $ {CalculateTotal()} (Shipping included)");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine();
    
    }
}