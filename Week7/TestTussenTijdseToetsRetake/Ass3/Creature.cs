public abstract class Creature
{
    private int _height;
    private int _weight;

    public virtual int Height
    {
        get => _height;
        protected set { if (value < 0) _height = 0; else _height = value; }
    }
    public int Weight
    {
        get => _weight;
        protected set { if (value < 0) _weight = 0; else _weight = value; }
    }

    public Creature(int h, int w)
    {
        Height = h;
        Weight = w;
    }

    public virtual void PrintInfo() => Console.WriteLine($"Height: {Height}\n Weight: {Weight}");

    public abstract bool Eat(string food);
}