class Square : Shape
{
    public readonly double Length;
    public Square(double length)
    {
        Length = length;
    }

    public override double Area { get { return Math.Pow(Length, 2); } }

    public override double Perimeter { get { return 4 * Length; } }

    public override string Info()
    {
        return $"Square with sides of {Length}";
    }
}