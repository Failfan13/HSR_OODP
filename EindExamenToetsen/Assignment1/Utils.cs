public static class Utils
{
    public static void DoubleSize<T>(T obj) where T : IResizeable
    {
        obj.Resize(2);
    }
}