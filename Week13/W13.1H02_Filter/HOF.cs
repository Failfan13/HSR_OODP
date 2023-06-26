public static class HOF
{
    // Filter goes here
    public static List<T> Filter<T>(List<T> elems, Func<T, bool> func)
    {
        return elems.Where(e => func(e)).ToList();
    }
}