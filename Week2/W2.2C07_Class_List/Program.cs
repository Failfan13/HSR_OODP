class Program {

    static public List<Pet> ListOfPets = new List<Pet>() {
        new Pet("Dog", "Nugent"),
        new Pet("Cat", "Steve"),
        new Pet("Goldfish", "Brutus")
    };
    public static void Main() {
        Person p1 = new Person("John", ListOfPets);

        foreach (var pet in p1.Pets) {
            Console.WriteLine($"{p1.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}
