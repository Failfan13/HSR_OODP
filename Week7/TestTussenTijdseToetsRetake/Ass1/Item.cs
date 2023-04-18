public class Item
{
    public readonly string Name;
    public double PricePerUnit;
    public int Quantity;

    public Item(string n, double p, int q)
    {
        Name = n;
        PricePerUnit = p;
        Quantity = q;
    }

    public double GetTotalPrice() => PricePerUnit * Quantity;

    public string GetInfo() => $"{Name} x {Quantity} = {GetTotalPrice()}";
}