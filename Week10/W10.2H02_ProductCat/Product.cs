using System.Collections;

public class Product : IEquatable<Product>, IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public bool Equals(Product? prod)
    {
        if (prod == null || !(prod is Product))
            return false;

        if (prod.Name == Name) return true;

        return false;
    }

    public int CompareTo(Product? prod)
    {
        if (prod == null) return 1;

        var price = Price.CompareTo(prod.Price);
        if (price != 0) return price;

        var name = Name.CompareTo(prod.Name);
        if (name != 0) return name;

        return 0;
    }

    public override string ToString()
    {
        return $"{Name} ({Price} x {Quantity})";
    }
}