public class Item
{
    public readonly string Name;
    public double PricePerUnit;
    public int Quantity;

    public Item(string name, double pricePerUnit, int quantity)
    {
        Name = name;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalPrice() => Quantity * PricePerUnit;
    public string GetInfo() => $"{Name} x {Quantity} = {GetTotalPrice()}";
}