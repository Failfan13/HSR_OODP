public class Shelter
{
    public List<IAnimal> Animals = null;

    public Shelter() => Animals = new List<IAnimal>();

    public void AddAnimal(IAnimal animal) => Animals.Add(animal);

    public void SortAnimals() => Animals.Sort();

    public T? SearchAnimal<T>(string name) where T : IAnimal
    {
        foreach (T animal in Animals.Where(a => a.GetType() == typeof(T)))
        {
            if (animal.Name == name) return (T)animal;
        }

        return default(T);
    }
}