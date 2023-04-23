public class Program
{
    public static void Main(string[] args)
    {
        // switch (args[1])
        // {
        //     case "IEquatable": TestIEquatable(); return;
        //     case "Equals": TestEquals(); return;
        //     case "EqualsObj": TestEqualsObj(); return;
        //     default: throw new ArgumentException();
        // }
        TestIEquatable();
        TestEquals();
        TestEqualsObj();
    }

    public static void TestIEquatable()
    {
        Type personType = typeof(Person);
        Type equatableType = typeof(IEquatable<>).MakeGenericType(personType);
        bool implementsEquatable = equatableType.IsAssignableFrom(personType);

        Console.WriteLine("Person implements IEquatable<Person>: " + implementsEquatable);
    }

    public static void TestEquals()
    {
        var people = new Person[] {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "John", Age = 30 },
            new Person { Name = "John", Age = 25 },
            new Person { Name = "Jane", Age = 30 },
        };

        for (int i = 0; i < people.Length; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                Person p1 = people[i];
                Person p2 = people[j];
                Console.WriteLine(
                    $"{p1.Name} ({p1.Age}) equals {p2.Name} ({p2.Age}): {p1.Equals(p2)}");
            }
        }
    }

    public static void TestEqualsObj()
    {

        var objects = new object[]
        {
            new Person { Name = "Max", Age = 5 },
            new Person { Name = "Max", Age = 5 },
            new Person { Name = "May", Age = 25 },
            new Student { Name = "May", Age = 25, StudentId = "01234" },
            new Dog { Name = "Max", Age = 5 },
            null,
        };

        for (int i = 0; i < objects.Length; i++)
        {
            for (int j = i + 1; j < objects.Length; j++)
            {
                object o1 = objects[i];
                object o2 = objects[j];
                if (ReferenceEquals(o1, null) || ReferenceEquals(o2, null))
                {
                    Console.WriteLine("Object is null. Skipping...");
                }
                else if ((o1 is Person && o2 is Person) ||
                    (o1 is Student && o2 is Person) ||
                    (o1 is Person && o2 is Student))
                {
                    Console.WriteLine($"{o1.GetType().Name} {o1} equals {o2.GetType().Name} {o2}: {o1.Equals(o2)}");
                }
                else if (o1 is Dog || o2 is Dog)
                {
                    Console.WriteLine($"{o1.GetType().Name} {o1} does not equal {o2.GetType().Name} {o2}");
                }
            }
        }
    }
}