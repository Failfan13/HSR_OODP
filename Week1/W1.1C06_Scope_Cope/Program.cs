Console.WriteLine("Give some text");
string newText, text = Console.ReadLine();

Console.WriteLine("What do you want to do with this text?");
Console.WriteLine("U: make all uppercase");
Console.WriteLine("L: make all lowercase");
Console.WriteLine("Any other key: do not change");
string choice = Console.ReadLine();

if (choice == (string)"U") {
    newText = text.ToUpper();
} else if (choice == (string)"L") {
    newText = text.ToLower();
} else {
    newText = text;

}
Console.WriteLine(newText);