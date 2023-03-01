class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        base.Sound = "Woof!";
    }

    public void Fetch()
    {
        Console.WriteLine($"{base.Name} fetches the stick");
    }
}