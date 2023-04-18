using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Interface": TestInterfaces(); return;
            case "Creature": TestCreature(); return;
            case "CreatureAccess": TestCreatureEncapsulation(); return;
            case "BirdFunctionality": TestBirdFunctionality(); return;
            default: throw new ArgumentException();
        }
    }

    public static void TestInterfaces()
    {
        Console.WriteLine("IFly is an interface: " + typeof(IFly).IsInterface);
        Console.WriteLine("ISing is an interface: " + typeof(ISing).IsInterface);
    }

    public static void TestCreature()
    {
        Type creatureType = typeof(Creature);

        Console.WriteLine("Class Creature cannot be instantiated: "
            + creatureType.IsAbstract);

        Console.WriteLine("Class Creature does NOT implement interface IFly: " 
            + !typeof(IFly).IsAssignableFrom(creatureType));
        Console.WriteLine("Class Creature does NOT implement interface ISing: " 
            + !typeof(ISing).IsAssignableFrom(creatureType));

        Console.WriteLine("Method Eat has no implementation: "
            + creatureType.GetMethod("Eat").IsAbstract);
        Console.WriteLine("Method PrintInfo is virtual: "
            + creatureType.GetMethod("PrintInfo").IsVirtual);
        Console.WriteLine("Property Height is virtual: "
            + creatureType.GetProperty("Height").GetMethod.IsVirtual);
    }

    public static void TestCreatureEncapsulation()
    {
        Console.WriteLine(
            "Property Height can be read anywhere, but only written to in this and derived classes: " +
            TestAccessModifierProperty("Creature", "Height", "Public", "Family"));
        Console.WriteLine(
            "Property Weight can be read anywhere, but only written to in this and derived classes: " +
            TestAccessModifierProperty("Creature", "Weight", "Public", "Family"));
    }

    public static void TestBirdFunctionality()
    {
        Bird birdInterface = new(0, 0);
        Console.WriteLine("Class Bird implements the IFly interface: " + (birdInterface is IFly));
        Console.WriteLine("Class Bird implements the ISing interface: " + (birdInterface is ISing));

        Console.WriteLine("\nTesting IFly functionality...");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Flying...");
            birdInterface.Fly();
            birdInterface.PrintInfo();
        }
        Console.WriteLine("Landing...");
        birdInterface.Land();
        birdInterface.PrintInfo();

        Console.WriteLine("\nTesting ISing functionality...");
        Console.WriteLine(birdInterface.Sing());

        Console.WriteLine("\nTesting Weight and Height boundaries...");
        Bird birdLowerBounds = new(-1, -1);
        Bird birdUpperBounds = new(25, 25);
        birdLowerBounds.PrintInfo();
        birdUpperBounds.PrintInfo();

        Bird bird = new(0, 0);
        List<string> food = new() { "Worm", "Seed", "Insect", "Carrot" };
        Console.WriteLine("\nTesting Eat functionality...");
        bird.PrintInfo();
        for (int i = 0; i < 3; i++)
        {
            foreach (string f in food)
            {
                Console.WriteLine($"Bird attempts to eat {f}. Does he like it? "
                    + bird.Eat(f));
                bird.PrintInfo();
            }
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