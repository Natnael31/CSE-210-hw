using System;

public class Order
{
    List<Product> _product = new List<Product>();
    Customer _customer = new Customer();

    public Order(List<Product> product, Customer customer)
    {
        _product = product;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        int shippingCost = 0;
        if (_customer.GetCustomerCountry() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        foreach (Product product in _product)
        {
            total += product.GetSubTotal();
        }
        Console.Write("Total cost: ");
        return total + shippingCost;
    }


    public string PackagingLabel()
    {
        string shippingLabel = "";
        foreach (Product product in _product)
        {
            shippingLabel += $"Id:{product.GetProductId()} Name:{product.GetProductName()}\n";
        }

        return shippingLabel;

    }

    public string ShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }
}