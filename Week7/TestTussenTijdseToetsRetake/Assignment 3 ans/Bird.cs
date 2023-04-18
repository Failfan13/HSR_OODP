public class Bird : Creature, IFly, ISing
{
    private readonly List<string> _foodsILike = new() { "Worm", "Seed", "Insect" };
    public override int Height
    {
        get => base.Height;
        protected set => base.Height = Math.Clamp(value, 0, 20); //At least 0; at most 20
    }

    public Bird(int height, int weight) : base(0, weight)
    {
        Height = height;
        Land();
    }

    public int Altitude { get; set; }
    public void Fly() => Altitude++;
    public void Land() => Altitude = 0;

    public string Sing() => "Chirp chirp";

    public override bool Eat(string food)
    {
        if (!(_foodsILike?.Contains(food) ?? false))
            return false;

        Height += 3;
        Weight += 5;
        return true;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Altitude: {Altitude}");
    }
}