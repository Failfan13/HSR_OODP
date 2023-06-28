using System.Globalization;

public class Plant : IComparable<Plant>
{
    public string Name { get; set; }
    public string Category { get; set; }
    private int _stock;
    public int Stock
    {
        get => _stock;
        private set { _stock = Math.Max(value, 0); }
    }
    public DateOnly LastSold { get; set; }

    public Plant(string name, string category, int stock, string lastSold)
    {
        Name = name;
        Category = category;
        Stock = stock;
        LastSold = DateOnly.ParseExact(lastSold, "dd-MM-yyyy", CultureInfo.InvariantCulture);
    }

    public int CompareTo(Plant? other)
    {
        return other == null ? 1 : Stock.CompareTo(other.Stock);
    }

    public int Sell(int amount)
    {
        int sellAble = (amount > Stock) ? amount - (amount - Stock) : amount;

        Stock -= sellAble;
        LastSold = DateOnly.FromDateTime(DateTime.Now);

        return sellAble;
    }
}