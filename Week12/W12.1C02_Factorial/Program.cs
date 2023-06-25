public class Program
{
    public static void Main()
    {
        Console.WriteLine("SaySum factorial shi");
        if (Int32.TryParse(Console.ReadLine(), out int newNum))
        {
            Console.WriteLine(Factorial(newNum));
        }
    }

    public static int Factorial(int n)
    {
        if (n < 0) return -1;
        else if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
}