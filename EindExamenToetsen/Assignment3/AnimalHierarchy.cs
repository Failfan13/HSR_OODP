public class AnimalHierarchy
{
    public static void PrintAnimalHierarchy(Animal zoo)
    {
        Action<Animal> printAction = a => Console.WriteLine(a.Name);

        Console.WriteLine("Animal Names:");
        // call the method PrintAnimalNames here
        PrintAnimalNames(zoo, printAction);
    }

    public static void PrintAnimalNames(Animal animal, Action<Animal> act)
    {
        if (animal == null) return;

        act(animal);

        if (animal.SubAnimals != null)
        {
            foreach (Animal subAni in animal.SubAnimals)
            {
                PrintAnimalNames(subAni, act);
            }
        }
    }
}