public class Tire
{
    public string Brand { get; }
    public int Durability { get; set; } = 5;

    public Tire(string brand) => Brand = brand;
}