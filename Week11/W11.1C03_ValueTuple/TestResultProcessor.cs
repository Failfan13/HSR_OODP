static class TestResultProcessor
{
    public static (double, bool) GetTestResult(double studentPt, double maxPt)
    {
        var points = (studentPt / maxPt) * 10;

        var pass = points >= 5.5;

        return (points, pass);
    }

    public static void PrintTestResult(Tuple<int, bool> grade)
    {
        Console.Write($"Grade: {grade.Item1}");
        Console.Write((grade.Item2 ? "Passed" : "Did not pass"));
    }
}