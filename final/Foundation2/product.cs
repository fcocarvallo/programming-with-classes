public class Product
{
    private string _name;
    private string _productId;
    private decimal _unitPrice;
    private int _quantity;

    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _productId = id;
        _unitPrice = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
         return _unitPrice;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    
}