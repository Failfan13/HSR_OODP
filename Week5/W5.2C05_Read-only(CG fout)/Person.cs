public class Person
{
    private readonly string _firstName, _lastName;

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FullName()
    {
        return $"{_firstName} {_lastName}";
    }
}