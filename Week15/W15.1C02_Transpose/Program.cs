public class Program
{
    public static void Main()
    {
        var array = new int[][] {
            new int[]{ 1, 2, 3, 4, 5 },
            new int[]{ 6, 7, 8, 9, 10 },
            new int[]{ 11, 12, 13, 14, 15 },
            new int[]{ 16, 17, 18, 19, 20 },
            new int[]{ 21, 22, 23, 24, 25 }
        };

        int rows = array.Length;
        int columns = array[0].Length;

        var newArray = Enumerable.Range(0, columns)
                                .Select(c => Enumerable.Range(0, rows)
                                    .Select(r => array[r][c]).ToArray())
                                .ToArray();

        foreach (int[] row in newArray)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}