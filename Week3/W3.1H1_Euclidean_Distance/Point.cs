class Point {
    public double X;
    public double Y;

    public Point(double pointX, double pointY) => (X, Y) = (pointX, pointY);

    public static double EuclideanDistance(Point p1, Point p2) {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}