using System.Collections;

public class ProductCatalogue : IEnumerable
{
    private List<Product> _products = new List<Product>();

    public void Add(Product prod)
    {
        _products.Add(prod);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return _products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public void SortProducts()
    {
        _products.Sort();
    }
}