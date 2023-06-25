public class Program
{
    static void Main()
    {
        int[] arr1 = new int[] { 5, 3, 10, -4, 6 };
        int min1 = ArrayUtils.FindMinimum(arr1);
        Console.WriteLine(min1);

        int[] arr2 = new int[] { 4, 1, 0 };
        int min2 = ArrayUtils.FindMinimum(arr2);
        Console.WriteLine(min2);

        int[] arr3 = new int[] { -3, -2, -1, 0, 1, 2, 3 };
        int min3 = ArrayUtils.FindMinimum(arr3);
        Console.WriteLine(min3);
    }
}