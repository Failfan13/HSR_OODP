public class Person
{
    public virtual string Name { get; }
    private int _age;
    public int Age { get => _age; private set => _age = Math.Max(0, value); }

    public Person(string name, int age) => (Name, Age) = (name, age);

    public void GrowOlder() => Age += 1;

    public override string ToString() => $"Name: {Name}\nAge: {Age}";
}