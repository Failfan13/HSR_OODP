class Car : ICommute
{
    public int Mileage { get; private set; }
    public Car() => Mileage = 0;

    void ICommute.Move(int distance)
    {
        Mileage += distance;
        Console.WriteLine($"Drove {distance} kms\nMileage: {Mileage} kms");
    }
}