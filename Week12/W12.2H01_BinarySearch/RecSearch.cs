public static class RecSearch
{
    public static int BinarySearch(int[] arr, int value)
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    // Overload BinarySearch here
    public static int BinarySearch(int[] arr, int v, int f, int l)
    {
        // if (f > l) return -1;

        // int midIndex = (f + l) / 2;

        // if (midIndex == v) return Array.IndexOf(arr, v);
        // else if (arr[midIndex] > v) return BinarySearch(arr, v, f, arr[midIndex] - 1);
        // else return BinarySearch(arr, v, arr[midIndex] + 1, l);

        if (f > l)
            return -1;

        int midIndex = (f + l) / 2;
        int midVal = arr[midIndex];

        if (midVal == v)
            return midIndex;
        else if (midVal > v)
            return BinarySearch(arr, v, f, midIndex - 1);
        else
            return BinarySearch(arr, v, midIndex + 1, l);
    }
}