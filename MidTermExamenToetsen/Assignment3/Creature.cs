public abstract class Creature
{
    private int _height;
    private int _weight;
    public virtual int Height { get => _height; protected set => _height = Math.Max(0, value); }
    public int Weight { get => _weight; protected set => _weight = Math.Max(0, value); }
    public Creature(int height, int weight) => (Height, Weight) = (height, weight);
    public virtual void PrintInfo() => Console.WriteLine($"Height: {Height}\nWeight: {Weight}");

    public abstract bool Eat(string food);
}