public static class ColorChecker
{
    public static void ColorExists(string color, List<string> colors)
    {
        bool result = HasMatch(...);
        Console.WriteLine($"Color '{color}' exists: {result}");
    }
    public static void ColorStartingWith(string letter, List<string> colors)
    {
        bool result = HasMatch(...);
        Console.WriteLine($"Color that starts with letter '{letter}' exists: {result}");
    }
}
