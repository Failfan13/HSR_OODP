public interface IAnimal : IComparable<IAnimal>
{
    string Name { get; set; }
    int Age { get; set; }
}