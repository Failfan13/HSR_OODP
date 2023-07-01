public class Dog : IAnimal, IComparable<IAnimal>, IEquatable<Dog>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Dog(string name, int age) => (Name, Age) = (name, age);

    public int CompareTo(IAnimal? obj)
    {
        if (obj == null) return 1;

        var otherDog = obj as Dog;

        return Age.CompareTo(otherDog.Age);
    }

    public bool Equals(Dog? obj)
    {
        if (obj == null) return false;

        if (Name.Equals(obj.Name) && Age.Equals(obj.Age)) return true;

        return false;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() == typeof(Dog)) return false;

        Dog otherDog = obj as Dog;

        return Equals(otherDog);
    }
}