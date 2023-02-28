class Person
{
    public string Name;
    public int Age;

    public Person(string name) : this(name, 0) { }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}