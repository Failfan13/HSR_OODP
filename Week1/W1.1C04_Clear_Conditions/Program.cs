Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the age of the student next to you?");
int otherAge = Convert.ToInt32(Console.ReadLine());

if (age == otherAge) {
    Console.WriteLine("Your ages are equal");
} else if (age < otherAge) { 
    Console.WriteLine("You are younger");
} else {
    Console.WriteLine("You are older");
}
