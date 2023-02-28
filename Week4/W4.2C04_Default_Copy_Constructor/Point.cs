class Point
{
    public double X;
    public double Y;

    public Point() : this(0, 0) { }
    public Point(double pointX) : this(pointX, 0) { }
    public Point(double pointX, double pointY)
    {
        X = pointX;
        Y = pointY;
    }
    public Point(Point instanceOfClass)
    {
        X = instanceOfClass.X;
        Y = instanceOfClass.Y;
    }
    public static double EuclideanDistance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}