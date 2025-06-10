using System;
using System.Collections.Generic;

// Address Class
class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetParam, string cityParam, string stateProvinceParam, string countryParam)
    {
        _street = streetParam;
        _city = cityParam;
        _stateProvince = stateProvinceParam;
        _country = countryParam;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}

// Customer Class
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string customerName, Address customerAddress)
    {
        _name = customerName;
        _address = customerAddress;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}

// Product Class
class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string prodName, string prodId, double unitPrice, int prodQuantity)
    {
        _name = prodName;
        _productId = prodId;
        _price = unitPrice;
        _quantity = prodQuantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}

// Order Class
class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer orderCustomer)
    {
        _customer = orderCustomer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}

// Program Class
class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA Customer
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "A100", 3.99, 4));
        order1.AddProduct(new Product("Pen", "B200", 1.50, 10));

        // Order 2 - International Customer
        Address address2 = new Address("42 Baker St", "London", "London", "UK");
        Customer customer2 = new Customer("Alice Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("USB Drive", "C300", 15.00, 2));
        order2.AddProduct(new Product("Headphones", "D400", 25.00, 1));
        order2.AddProduct(new Product("Charger", "E500", 10.00, 1));

        // Display Order 1 Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine();

        // Display Order 2 Details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
