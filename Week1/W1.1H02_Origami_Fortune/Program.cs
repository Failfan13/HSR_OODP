string color = "";
int number, lengthWord, remainder;
number = lengthWord = remainder = 0;

while (color == "") {
    Console.WriteLine("Pick a color (red/blue/green/yellow):");
    string? choiceColor = Console.ReadLine()?.ToLower();
    if (new [] {"red", "blue", "green", "yellow"}.Contains(choiceColor)) {
        color = choiceColor;
        break;
    }
}
while (number == 0) {
    Console.WriteLine("Pick a number (1-8):");
    int choiceNumber = Convert.ToInt32(Console.ReadLine()?.ToLower());
    if (choiceNumber >= 1 && choiceNumber <= 8) {
        number  = choiceNumber;
        break;
    }
}

lengthWord = color.Length;

remainder = ((lengthWord + number) % 4);

var fortuneNumber = ++remainder;