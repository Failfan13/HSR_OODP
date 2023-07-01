public class Animal
{
    public string Name { get; set; }
    public List<Animal> SubAnimals { get; set; }

    public Animal(string name, List<Animal> subAnimal)
    {
        Name = name;
        SubAnimals = subAnimal;
    }
}