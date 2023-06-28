public class Inventory
{
    private Dictionary<string, Product> _products = new Dictionary<string, Product>();

    public void AddProduct(string name, double price, int quantity)
    {
        if (!_products.Keys.Contains(name))
        {
            _products.Add(name, new Product(name, price, quantity));
        }
        else
        {
            _products[name].Quantity += quantity;
        }
    }

    public void AddProduct(string name, double price) => AddProduct(name, price, 0);

    public void RemoveProduct(string name) => _products.Remove(name);

    public Product GetProduct(string name) => _products[name];

    public bool GetInventorySummary()
    {
        Console.WriteLine("Total products:" + _products.Sum(p => p.Value.Quantity));
        Console.WriteLine("Total value: $" + Math.Round(_products.Sum(p => p.Value.Price * p.Value.Quantity), 2));
        return true;
    }
}