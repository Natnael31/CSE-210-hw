using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool GetCountry()
    {
        bool country;
        if (_country == "USA")
        {
            country = true;
        }
        else
        {
            country = false;
        }
        return country;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country} ";
    }

}