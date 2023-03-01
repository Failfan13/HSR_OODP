class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        base.Sound = "Meow!";
    }

    public void Climb()
    {
        Console.WriteLine($"{base.Name} climbs the curtains");
    }
}