public static class ColorChecker
{
    public static void ColorExists(string color, List<string> colors)
    {
        bool result = HasMatch(colors, c => c == color);
        Console.WriteLine($"Color '{color}' exists: {result}");
    }
    public static void ColorStartingWith(string letter, List<string> colors)
    {
        bool result = HasMatch(colors, c => c[0] == letter[0]);
        Console.WriteLine($"Color that starts with letter '{letter}' exists: {result}");
    }

    public static bool HasMatch(List<string> colors, Func<string, bool> func)
    {
        if (colors == null || colors.Count <= 0) return false;

        if (func(colors.First())) return true;

        colors.RemoveAt(0);

        return HasMatch(colors, func);
    }
}
