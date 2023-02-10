Console.WriteLine("You have one chance to guess this six-letter word:");
string secretWord = "Length";
Console.WriteLine("Le..th");
string inp = Console.ReadLine();

if (inp.Length < 6) {
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
} else if (!Char.IsUpper(inp[0])){
    Console.WriteLine("Kind of correct; the case was just wrong");
} else if (inp == secretWord) {
    Console.WriteLine("Correct!");
} else{
    Console.WriteLine("Incorrect!");
    }