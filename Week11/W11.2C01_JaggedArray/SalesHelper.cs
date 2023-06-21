static class SalesHelper
{
    public static void PrintSalesData(int[][] jArr)
    {
        for (int i = 0; i < jArr.Length; i++)
        {
            string str = $"Sales data for department {i + 1}:\n";

            for (int j = 0; j < jArr[i].Length; j++)
                str += $" - {jArr[i][j]}\n";

            Console.WriteLine(str);
        }


    }
}