public class Order {

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public decimal ComputeTotalCost()
    {
        decimal total = 0;
        
        // Calculate total cost of products
        foreach(Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Determine shipping cost
        decimal shippingCost;
        if (_customer.LivesInUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        // Return the total cost with shipping
        return total + shippingCost;

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        // Iterate through each product and enter its details to the label
        foreach (Product product in _products)
        {
            label += product.GetProductName() + " (ID: " + product.GetProductId() + ")\n";
        }
        return label;
    }
}