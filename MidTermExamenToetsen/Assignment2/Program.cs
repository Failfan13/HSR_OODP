using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "INHERITANCE": TestInheritance(); break;
            case "BOOKACCESS": TestBookAccessMods(); break;
            case "BOOKFUNC": TestBookFunc(); break;
            case "EBOOKFUNC": TestEBookFunc(); break;
            case "PERSONACCESS": TestPersonAccessMods(); break;
            case "PERSONFUNC": TestPersonFunc(); break;
            case "MEMBERACCESS": TestMemberAccessMods(); break;
            case "MEMBERFUNC": TestMemberFunc(); break;
            default: throw new ArgumentException();
        }
    }

    public static void TestInheritance()
    {
        Console.WriteLine("EBook is derived from Book: "
            + typeof(EBook).IsSubclassOf(typeof(Book)));
        Console.WriteLine("Member is derived from Person: "
            + typeof(Member).IsSubclassOf(typeof(Person)));
    }

    public static void TestBookAccessMods()
    {
        Console.WriteLine(
            "Property Title is public and read-only: " +
            TestAccessModifierProperty("Book", "Title", "Public", null));
        Console.WriteLine(
            "Property Author is public and read-only: " +
            TestAccessModifierProperty("Book", "Author", "Public", null));
        Console.WriteLine(
            "Property Language can be read anywhere, " +
            "but can only be written to in this and derived classes: " +
            TestAccessModifierProperty("Book", "Language", "Public", "Family"));
        Console.WriteLine();
    }

    public static void TestBookFunc()
    {
        List<Book> books = new()
        {
            new Book("C# Basics", "Ian Griffiths", "EN"),
            new Book("C# Advanced", "Ian Griffiths"),
            new Book("C# Basis", "Dan Gookin", "NL"),
            new Book("C# Gevorderd", "Dan Gookin", "NL"),
        };

        foreach (var book in books)
        {
            book.PrintInfo();
            Console.WriteLine();
        }
    }

    public static void TestEBookFunc()
    {
        List<Book> books = new()
        {
            new EBook("C# Basics", "Ian Griffiths"),
            new Book("C# Advanced", "Ian Griffiths", "EN"),
            new Book("C# Basis", "Dan Gookin", "NL"),
            new EBook("C# Gevorderd", "Dan Gookin", "NL"),
        };

        foreach (var book in books)
        {
            book.PrintInfo();
            (book as EBook)?.UpdateLanguage("FR");
            book.PrintInfo();
            Console.WriteLine();
        }
    }

    public static void TestPersonAccessMods()
    {
        Console.WriteLine(
            "Property Name is public and read-only: " +
            TestAccessModifierProperty("Person", "Name", "Public", null));
        Console.WriteLine(
            "Property Age can be read publicly and set privately: " +
            TestAccessModifierProperty("Person", "Age", "Public", "Private"));
    }

    public static void TestPersonFunc()
    {
        Person person = new("John", 20);
        Console.WriteLine(person);
        for (int i = 0; i < 10; i++)
        {
            person.GrowOlder();
        }
        Console.WriteLine(person);

        Console.WriteLine();
        person = new("Jane", -5);
        Console.WriteLine(person);
    }

    public static void TestMemberAccessMods()
    {
        Console.WriteLine(
            "Property NumberOfBooksBorrowed can be read anywhere, but only written to in this class: " +
            TestAccessModifierProperty("Member", "NumberOfBooksBorrowed", "Public", "Private") + "\n"
        );
    }

    public static void TestMemberFunc()
    {
        Member member = new("Jack", 15);
        Console.WriteLine(member + "\n");

        List<Book> books = new()
        {
            new EBook("C# Basics", "Ian Griffiths", "EN"),
            new Book("C# Advanced", "Ian Griffiths", "EN"),
            new Book("C# Pro", "Ian Griffiths"),
            null,
            new Book("C# Basis", "Dan Gookin", "NL"),
            new EBook("C# Gevorderd", "Dan Gookin", "NL"),
            new Book("C# Pro", "Dan Gookin", "NL"),
        };

        foreach (var book in books)
        {
            member.BorrowBook(book);
            Console.WriteLine(member + "\n");
        }
    }

    private static string TestAccessModifierProperty(string cls, string property, string getTest, string setTest)
    {
        var p = Type.GetType(cls).GetProperty(property,
          BindingFlags.NonPublic |
          BindingFlags.Public |
          BindingFlags.Instance);
        if (p == null)
            return $"Property not found: {property}";

        var flag = false;
        if (getTest != null)
        {
            flag = p.CanRead;
            if (getTest == "Public")
                flag = p.GetMethod.IsPublic;
            else if (getTest == "Family")
                flag = p.GetMethod.IsFamily;
            else if (getTest == "Private")
                flag = p.GetMethod.IsPrivate;
            else
                flag = false;
        }
        if (setTest != null)
        {
            flag = flag && p.CanWrite;
            if (setTest == "Public")
                flag = flag && p.SetMethod.IsPublic;
            else if (setTest == "Family")
                flag = flag && p.SetMethod.IsFamily;
            else if (setTest == "Private")
                flag = flag && p.SetMethod.IsPrivate;
            else
                flag = false;
        }
        return flag == true ? "Correct!" : "Incorrect.";
    }
}