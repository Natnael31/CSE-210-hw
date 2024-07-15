using System;

public class Customer
{
    private string _name;
    Address _address = new Address();

    public Customer()
    {

    }

    public void SetCustomerName(string name)
    {
        _name = name;
    }

    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }
    public bool GetCustomerCountry()
    {
        return _address.GetCountry();
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }


}