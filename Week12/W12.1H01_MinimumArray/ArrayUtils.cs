public static class ArrayUtils
{
    public static int FindMinimum(int[] arr)
    {
        return RecMinimum(arr, arr.Length - 1);
    }

    // RecMinimum goes here
    private static int RecMinimum(int[] arr, int i)
    {
        // if (arr[i] < arr[0])
        // {
        //     int temp = arr[0];
        //     arr[0] = arr[i];
        //     arr[i] = temp;
        // }

        // if (i == arr.Length - 1) return arr[0];

        // return RecMinimum(arr, i + 1);

        // if (arr[i] < arr[0])
        // {
        //     int temp = arr[0];
        //     arr[0] = arr[i];
        //     arr[i] = temp;
        // }

        if (i == 0) return arr[0];

        return Math.Min(arr[i], RecMinimum(arr, i - 1));
    }
}