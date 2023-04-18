public class Person
{
    public virtual string Name { get; }
    private int _age;
    public int Age
    {
        get => _age;
        private set => _age = value > 0 ? value : 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void GrowOlder() => Age++;
    public override string ToString() => $"Name: {Name}\nAge: {Age}";
}