public class Bird : Creature, IFly, ISing
{
    private int _height;
    public int Altitude { get; set; }
    public override int Height
    {
        get => _height;
        protected set
        {
            _height = value switch
            {
                < 0 => 0,
                > 20 => 20,
                _ => value
            };
        }
    }

    public Bird(int height, int weight)
        : base(height, weight)
    {
        Height = height;
    }

    public void Fly()
    {
        Altitude++;
    }

    public void Land()
    {
        Altitude = 0;
    }

    public string Sing()
    {
        return "Chirp chirp";
    }

    public override bool Eat(string food)
    {
        List<string> foods = new() { "Worm", "Seed", "Insect" };

        if (foods.Any(x => x == food))
        {
            Height += 3;
            base.Weight += 5;
            return true;
        }
        return false;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Height: {Height}\nWeight: {base.Weight}\nAltitude: {Altitude}");
    }
}