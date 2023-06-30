public class Program
{
    public static void Main()
    {
        int[][] SalesArr = null;

        Console.WriteLine("How many departments are there");
        string inp1 = Console.ReadLine();

        Console.WriteLine("What are the sales numbers for each department");
        string inp2 = Console.ReadLine();

        Console.WriteLine(inp1);
        Console.WriteLine(inp2);

        if (Int32.TryParse(inp1, out int departments))
            SalesArr = new int[departments][];

        SalesHelper.PrintSalesData(SalesArr);
    }
}
