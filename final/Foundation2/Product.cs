public class Product
{
    private string _productName;
    private string _productId;
    private decimal _pricePerUnit;
    private int _productQuantity;

    public Product(string productName, string productId, decimal pricePerUnit, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _productQuantity = productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public decimal GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public void SetPricePerUnit(decimal pricePerUnit)
    {
        _pricePerUnit = pricePerUnit;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public void SetProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }

    public decimal CalculateProductTotalCost()
    {
        return _pricePerUnit * _productQuantity;
    }
}