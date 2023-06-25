public class Program
{
    public static void Main()
    {
        var ans1 = Console.ReadLine();
        var ans2 = Console.ReadLine();
        if (Int32.TryParse(ans1, out int newInt1))
        {
            if (Int32.TryParse(ans2, out int newInt2))
                Console.WriteLine(RecursiveLog(newInt1, newInt2));
        }
    }

    public static int RecursiveLog(int num, int logBase)
    {
        if (num < logBase) return 0;

        return 1 + RecursiveLog(num / logBase, logBase);
    }
}