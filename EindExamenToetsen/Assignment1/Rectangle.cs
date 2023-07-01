public class Rectangle : Shape, IComparable<Rectangle>, IResizeable
{
    public Rectangle(double width, double height, int brightness)
        : base(width, height, brightness) { }

    public int CompareTo(Rectangle? obj)
    {
        if (obj == null) return 1;

        var brightness = Brightness.CompareTo(obj.Brightness);
        if (brightness != 0) return -1;

        var area = base.CalculateArea().CompareTo(obj.CalculateArea());
        if (area != 0) return -1;

        return 0;
    }

    public void Resize(double scale)
    {
        Height *= scale;
        Width *= scale;
    }

}