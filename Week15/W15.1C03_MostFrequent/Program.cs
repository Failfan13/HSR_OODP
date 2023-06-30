public class Program
{
    public static void Main()
    {
        Console.Write("Input string: ");
        var str = Console.ReadLine();

        // Array.ForEach(str.GroupBy(l => l).ToArray(), e => Console.WriteLine($"Char [{e.Key}]: {e.Count()}"));
        var group = str.GroupBy(l => l).MaxBy(l => l.Count());

        Console.WriteLine($@"{str} → {group.Key}");
    }
}