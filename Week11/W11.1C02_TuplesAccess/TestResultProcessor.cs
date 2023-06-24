static class TestResultProcessor
{
    public static Tuple<double, bool> GetTestResult(double points, double maxPoints)
    {
        var totPoints = (points / maxPoints) * 10;

        var pass = totPoints >= 5.5;

        return Tuple.Create<double, bool>(totPoints, pass);
    }

    public static void PrintTestResult(Tuple<int, bool> grade)
    {
        Console.Write($"Grade: {grade.Item1}");
        Console.Write((grade.Item2 ? "Passed" : "Did not pass"));
    }
}