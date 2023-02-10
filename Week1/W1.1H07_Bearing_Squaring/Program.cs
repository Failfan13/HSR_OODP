var directions = new List<string> {"North", "East", "South", "West"};
var cardinalDir = new List<string> ();

Console.WriteLine("For each direction, input Y/N if it is valid.");

for (var i = 0; i < directions.Count; i++) {
    string direction = directions[i];
    Console.WriteLine($"{direction}? Y/N");
    if (Console.ReadLine()?.ToUpper() == "Y")
    cardinalDir.Add(direction);
};

Console.WriteLine($"From here you can go:");

// https://stackoverflow.com/questions/7175580/use-string-contains-with-switch

string compas = "    |";
bool north = false;

for (var i = 0; i < cardinalDir.Count; i++) {
    string direction = cardinalDir[i];
    int stringLen = compas.Length;
    if (direction == "North") {
        compas = compas.Insert(0, "    N\n    |\n");
        north = true;
        stringLen = stringLen + 12;
    } else if (direction == "East") {
        compas = compas.Insert(stringLen, "---E");
        stringLen = stringLen + 5;
    } else if (direction == "South") {
        compas = compas.Insert(stringLen, "\n    |\n    S\n");
    }else if (direction == "West") {
        compas = compas.Remove((!north == true ? 0 : 12), 4).Insert((!north == true ? 0 : 12), "W---");
    };
};

Console.WriteLine(compas);

Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
int bearing = Convert.ToInt32(Console.ReadLine());

if (bearing < 0) {
    bearing = Math.Abs(-360 - (bearing % 360));
} else if (bearing > 360) {
    bearing = bearing % 360;
};

string figureDirection = bearing switch {
    > 45 and <= 135 => "East",
    > 135 and <= 225 => "South",
    > 225 and <= 315 => "West",
    >= 0 and <= 360 => "North",
    _ => "West"
};

if (cardinalDir.Contains(figureDirection)) {
    Console.WriteLine($"You are going {figureDirection.ToLower()}");
} else {
    Console.WriteLine($"You can't go {figureDirection.ToLower()}");
};