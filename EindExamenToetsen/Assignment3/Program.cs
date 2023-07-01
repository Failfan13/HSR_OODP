public static class Program
{
    public static void Main(string[] args)
    {
        // switch (args[1])
        // {
        //     case "TestPrintAnimalHierarchy":
        //         TestPrintAnimalHierarchy();
        //         break;

        //     // CodeTester class
        //     case "CodeTesterLambda":
        //         //CodeTester.TestLambda();
        //         break;
        //     default:
        //         Console.WriteLine("No test found");
        //         break;
        // }

        TestPrintAnimalHierarchy();
    }
    public static void TestPrintAnimalHierarchy()
    {
        Animal lion = new Animal("Lion", new List<Animal>
        {
            new Animal("Cub 1", null),
            new Animal("Cub 2", null)
        });

        Animal elephant = new Animal("Elephant", new List<Animal>
        {
            new Animal("Calf 1", null),
            new Animal("Calf 2", new List<Animal>
            {
                new Animal("Calf 2.1", null),
                new Animal("Calf 2.2", null)
            })
        });

        Animal zoo = new Animal("Zoo", new List<Animal>
        {
            lion,
            elephant
        });

        AnimalHierarchy.PrintAnimalHierarchy(zoo);
    }
}
