using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] persons = new string[] { "Dave", "John", "Peter", "Johanna", "Bart", "Henk", "Marie" };
        string[] students = new string[] { "Dave", "Micheal", "Roxanne", "Johanna", "John", "Bart", "Henk" };

        Console.WriteLine("These names are in both datasets:");
        // solutions here
        string[] doubleOcurrance = persons.Where(n => students.Contains(n)).ToArray();
        foreach (string name in doubleOcurrance)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();
        Console.WriteLine("These names are unique:");
        // solution here
        string[] singleOccurance1 = persons;

        singleOccurance1 = singleOccurance1.Union(students).ToArray();
        Array.Sort(singleOccurance1);

        foreach (string name in singleOccurance1)
        {
            Console.WriteLine(name);
        }
    }
}