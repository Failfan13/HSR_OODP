// public class Bird : Creature, IFly, ISing
// {
//     public int Altitude { get; set; }
//     public override int Height
//     {
//         get => base.Height;
//         protected set
//         {
//             if (value < 0) base.Height = 0;
//             else if (value > 20) base.Height = 20;
//             else base.Height = value;
//         }
//     }

//     public Bird(int h, int w) : base(h, w) { }

//     public void Fly() => Altitude++;

//     public void Land() => Altitude = 0;

//     public string Sing() => "Chirp chirp";

//     public override bool Eat(string food)
//     {
//         if (food == "Worm" || food == "Seed" || food == "Insect")
//         {
//             Height += 3;
//             Weight += 5;
//             return true;
//         }
//         return false;
//     }

//     public override void PrintInfo()
//     {
//         base.PrintInfo();
//         Console.WriteLine($"Altitude: {Altitude}");
//     }
// }

public class Bird : Creature, IFly, ISing
{
    private readonly List<string> _foodsILike = new() { "Worm", "Seed", "Insect" };
    public override int Height
    {
        get => base.Height;
        protected set => base.Height = Math.Clamp(value, 0, 20); //At least 0; at most 20
    }

    public Bird(int height, int weight) : base(height, weight) { }

    public int Altitude { get; set; }
    public void Fly() => Altitude++;
    public void Land() => Altitude = 0;

    public string Sing() => "Chirp chirp";

    public override bool Eat(string food)
    {
        if (!_foodsILike.Contains(food))
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