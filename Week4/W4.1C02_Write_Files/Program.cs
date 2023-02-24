class Program
{
    public static void Main()
    {
        File.AppendAllText(@"MyTextFile.txt", $"\nAdded line.");
    }
}
