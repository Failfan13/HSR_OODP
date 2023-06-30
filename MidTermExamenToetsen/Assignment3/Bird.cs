public class Bird : Creature, IFly, ISing
{
    public override int Height
    {
        get => base.Height;
        protected set => base.Height = Math.Max(20, value);
    }

    public int Altitude { get; set; }

    public Bird(int height, int weight)
        : base(height, weight) { }

    public void Fly() => Altitude++;
    public void Land() => Altitude = 0;
    public void Sing() => Console.WriteLine("Chirp chirp");
    public override bool Eat(string food)
    {
        if ((new List<string>() { "Worm", "Seed", "Insect" }).Contains(food))
        {
            Height += 3;
            Weight += 5;
            return true;
        }
        return false;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Altitude: {Altitude}");
    }
}