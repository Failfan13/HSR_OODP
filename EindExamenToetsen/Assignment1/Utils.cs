public static class Utils
{
    public static void DoubleSize<T>(T obj) where T : IResizable
    {
        obj.Resize(2);
    }
}