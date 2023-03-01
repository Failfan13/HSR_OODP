class Electronics : Product
{
    public string Brand, Model;
    public Electronics(string name, double price, int amount, string brand, string model)
           : base(name, price, amount)
    {
        this.Brand = brand;
        this.Model = model;
    }

    public override void Sell(int amount)
    {
        if (amount <= base.Amount)
        {
            base.Amount -= amount;
            Console.WriteLine($"{amount} units of {Name} have been sold.");
            base.Amount = 5;
        }
        else
        {
            Console.WriteLine($"{Name} is out of stock.");
        }
    }

    public override string ToString()
    {
        return $"Name: {base.Name} ({Brand} {Model}); price: {base.Price}; stock: {base.Amount}";
    }
}