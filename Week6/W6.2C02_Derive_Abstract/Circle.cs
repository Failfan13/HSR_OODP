class Circle : Shape
{
    public readonly double Radius;
    public Circle(double radius) => Radius = radius;

    public override double Area { get { return Math.PI * (Math.Pow(Radius, 2)); } }
    public override double Perimeter { get { return 2 * (Math.PI * Radius); } }

    public override string Info()
    {
        return $"Circle with a radius of {Radius}";
    }
}