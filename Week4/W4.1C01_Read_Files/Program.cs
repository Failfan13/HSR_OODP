class Program
{
    public static void Main()
    {
        var file = File.ReadAllText(@"MyTextFile.txt");
        Console.WriteLine(file);
    }
}