class Clothes : Product
{
    public string Size, Material;

    public Clothes(string name, double price, int amount, string size, string material)
        : base(name, price, amount)
    {
        this.Size = size;
        this.Material = material;
    }

    public override string ToString()
    {
        return $"{base.ToString()}; size: {Size}; material: {Material}";
    }
}