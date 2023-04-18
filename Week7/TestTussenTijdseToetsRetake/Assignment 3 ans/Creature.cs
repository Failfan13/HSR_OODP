public abstract class Creature
{
    public virtual int Height { get; protected set; }
    public int Weight { get; protected set; }

    public Creature(int height, int weight)
    {
        Height = Math.Max(height, 0); //At least 0
        Weight = Math.Max(weight, 0);
    }

    public virtual void PrintInfo()
        => Console.WriteLine( $"Height: {Height}\nWeight: {Weight}");
    public abstract bool Eat(string food);
}