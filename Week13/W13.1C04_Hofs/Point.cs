public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Func<Point, Point, double> GetDistanceCalculator(double factor)
    {
        return (p1, p2) =>
        {
            return Math.Sqrt(
                (p2.X - p1.X) *
                (p2.X - p1.X) +
                (p2.Y - p1.Y) *
                (p2.Y - p1.Y) *
                factor);
        };
    }
}