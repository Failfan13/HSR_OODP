class Circle {
    public double Radius;

    public Circle(double rad) => Radius = rad;

    public double Area() {
        return (Math.PI * Math.Pow(Radius, 2));
    }
}