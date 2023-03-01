class Program
{
    public static void Main()
    {
        var p1 = new Person("John Doe");
        var p2 = new Student("Jane Doe");

        Console.WriteLine(p1.Introduce());
        Console.WriteLine(p2.Introduce());
        Console.WriteLine(p2.Status());
        p2.Graduate();
        Console.WriteLine(p2.Status());
    }
}