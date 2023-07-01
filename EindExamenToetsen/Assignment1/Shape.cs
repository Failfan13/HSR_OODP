public class Shape : IEquatable<Shape>
{
    public double Height { get; set; }
    public double Width { get; set; }
    public int Brightness { get; set; }

    public Shape(double width, double height, int brightness)
    {
        Width = width;
        Height = height;
        Brightness = brightness;
    }

    public double CalculateArea() => Width * Height;

    public bool Equals(Shape? obj)
    {
        if (obj == null) return false;

        return Height.Equals(obj.Height) && Width.Equals(obj.Width) && Brightness.Equals(obj.Brightness);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Shape)) return false;

        return Equals(obj as Shape);
    }


}