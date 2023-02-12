using System;

class Person
{
    public string Name;
    public Animal Pet;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }
    public string Info()
    {   
        string info;
        try {
            info = $"{Name} has a pet that makes the sound {Pet.MakeSound()}";
        } catch (Exception NullReferenceException) {
            info = $"{Name} has no pet";
        }
        return info;
    }
}