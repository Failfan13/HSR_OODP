public class Program {

    public static void Main() {
        string fn, ln;
        Console.WriteLine("First name");
        fn = Console.ReadLine();
        Console.WriteLine("Last name");
        ln = Console.ReadLine();
        DisplayName(fn, ln);
    }

    public static void DisplayName(string firstName, string lastName) => Console.WriteLine(Name(firstName, lastName));
    public static string Name(string firstName, string lastName) => $"{firstName} {lastName}";
}