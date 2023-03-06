abstract class Person
{
    public abstract int Age { get; set; }
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public abstract string Greet()
    {
        return $"Hello";
    }

    public virtual string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}