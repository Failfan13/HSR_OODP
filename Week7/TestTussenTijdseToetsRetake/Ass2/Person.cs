public class Person
{
    public virtual string Name { get; }

    private int _age;
    public int Age
    {
        get => _age;
        protected set
        {
            if (value < 0) _age = 0; else _age = value;
        }
    }

    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }

    public void GrowOlder() => Age++;

    public override string ToString() => $"Name: {Name}\n Age: {Age}";
}