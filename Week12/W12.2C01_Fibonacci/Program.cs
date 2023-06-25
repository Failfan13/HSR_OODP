public class Program
{
    static void Main()
    {
        Console.Write("What is n? ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Fibonacci({n}) = " + Fibonacci(n));
    }

    // Method Fibonacci goes here
    private static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        else if (n == 1) return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}