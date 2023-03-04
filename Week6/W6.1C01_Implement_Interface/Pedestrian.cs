public class Pedestrian : Person, ICommute
{
    public Pedestrian(string name) : base(name) { }

    void ICommute.Move(int distance)
    {
        Console.WriteLine($"Walked {distance} kms");
    }
}