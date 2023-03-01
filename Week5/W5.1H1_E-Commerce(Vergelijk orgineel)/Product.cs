class Product
{
    public string Name;
    public double Price;
    public int Amount;

    public Product(string name, double price, int amount)
    {
        this.Name = name;
        this.Price = price;
        this.Amount = amount;
    }

    public virtual void Sell(int amount)
    {
        if (amount <= Amount)
        {
            Amount -= amount;
            Console.WriteLine($"{amount} units of {Name} have been sold.");
        }
        else
        {
            Console.WriteLine($"{Name} is out of stock.");
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}; price: {Price}; stock: {Amount}";
    }
}