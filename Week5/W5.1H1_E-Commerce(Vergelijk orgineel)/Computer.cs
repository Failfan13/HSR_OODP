class Computer : Electronics
{
    public Computer(string name, double price, int amount, string brand, string model)
        : base(name, price, amount, brand, model) { }
    public override void Sell(int amount)
    {
        if (amount <= base.Amount)
        {
            Console.WriteLine($"{amount} units of {Name} have been sold.");
            base.Amount = 5;
        }
        else
        {
            Console.WriteLine($"{Name} is out of stock.");
        }
    }
}