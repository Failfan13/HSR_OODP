class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Person(string name)
    {
        this.Name = name;
        this.Age = 0;
    }
}