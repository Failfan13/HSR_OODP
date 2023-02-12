class Person
{
    //Write the fields and the constructor here
    public string FirstName;
    public string LastName;
    public Person(string firstName, string lastName) {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string Introduce() => $"I am {this.FirstName} {this.LastName}";
}