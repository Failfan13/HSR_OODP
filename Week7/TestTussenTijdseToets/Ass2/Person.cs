public class Person
{
    public string Name { get; protected set; }
    public int _age;

    public int Age
    {
        get => _age;
        private set
        {
            if (value < 0)
            {
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void GrowOlder() => Age++;
    public override string ToString() => $"Name: {Name}\nAge: {Age}";
}