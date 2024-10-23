public class Customer {

    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    public bool LivesInUsa()
    {
        return _customerAddress.IsUsa();
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }
}