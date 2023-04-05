public abstract class Creature
{
    public virtual int Height { get; protected set; }
    private int _weight;

    public int Weight
    {
        get => _weight;
        protected set
        {
            _weight = (value < 0 ? 0 : value);
        }
    }

    public Creature(int height, int weight)
    {
        Height = height;
        Weight = weight;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Height: {Height}\nWeight: {Weight}");
    }

    public abstract bool Eat(string food);
}