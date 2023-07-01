public class Cat : IAnimal, IComparable<IAnimal>, IEquatable<Cat>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Cat(string name, int age) => (Name, Age) = (name, age);

    public int CompareTo(IAnimal? obj)
    {
        if (obj == null) return 1;

        var otherCat = obj as Cat;

        return Age.CompareTo(otherCat);
    }

    public bool Equals(Cat? obj)
    {
        if (obj == null) return false;

        return Name.Equals(obj.Name) && Age.Equals(obj.Age);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Cat)) return false;

        return Equals(obj as Cat);
    }
}