public class Program
{
    static void Main()
    {
        Console.WriteLine("Give two numbers:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        PrintResult((x, y) => x + y, number1, number2);
        PrintResult((x, y) => x - y, number1, number2);
        PrintResult((x, y) => x * y, number1, number2);
        PrintResult((x, y) => (int)Math.Pow(x, y), number1, number2);
    }

    public static void PrintResult(Func<int, int, int> res, int num1, int num2)
    {
        Console.WriteLine("The result is: " + res(num1, num2));
    }
}