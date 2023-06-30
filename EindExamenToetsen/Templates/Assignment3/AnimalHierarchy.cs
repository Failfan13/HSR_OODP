public class AnimalHierarchy
{
    public static void PrintAnimalHierarchy(Animal zoo)
    {
        Action<Animal> printAction = a => Console.WriteLine(a.Name);

        Console.WriteLine("Animal Names:");
        // call the method PrintAnimalNames here

    }
}