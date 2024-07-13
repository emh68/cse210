using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateOrderTotal()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculateProductTotalCost();
        }
        return totalCost + CalculateShippingCost();
    }

    public decimal CalculateShippingCost()
    {
        return _customer.IsCustomerInUsa() ? 5 : 35;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"PID: {product.GetProductId()} - {product.GetProductName()} - Qty({product.GetProductQuantity()})    ${product.GetPricePerUnit():0.00}\n";
        }
        return packingLabel.Trim();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddressString()}";
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
}

