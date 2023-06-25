public class Program
{
    public static void Main()
    {
        Console.WriteLine("Saysum mf");
        var ans = Console.ReadLine();

        if (Int32.TryParse(ans, out int newNum))
        {
            Console.WriteLine(RecursiveSum(newNum));
        }
    }

    public static int RecursiveSum(int num)
    {
        if (num <= 0) return 0;
        return num + RecursiveSum(num - 1);
    }
}
