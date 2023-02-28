public static class HRTools
{
    public static void PrintName(string text)
    {
        Console.WriteLine(text);
    }
    public static void PrintName(string text1, string text2)
    {
        Console.WriteLine($"{text1} {text2}");
    }
    public static void PrintName(char letter, string text)
    {
        Console.WriteLine($"{letter.ToString()}. {text}");
    }

    public static int IncreaseSalery(int number)
    {
        return number + 100;
    }
    public static double IncreaseSalery(int number, double doub)
    {
        return (number * doub) + number;
    }
}