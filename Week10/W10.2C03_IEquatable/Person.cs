public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public bool Equals(Person? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (Name.Equals(obj.Name) && Age.Equals(obj.Age))
        {
            return true;
        }

        return false;
    }
}