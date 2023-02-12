class Program {
    public static void Main() {
        List<Pet> listOfPets = new List<Pet> {
            new Pet("Dog", "Nugent"), 
            new Pet("Cat", "Steve"), 
            new Pet("Goldfish", "Brutus")
        };

        foreach (var pet in listOfPets) {
            Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        };
    }
}