Console.WriteLine("What direction would you like to go?");
int x = 0, y = 0;
string? direction = Console.ReadLine()?.ToLower();

int yeet = direction switch{
    "up" => y++,
    "down" => y--,
    "right" => x++,
    "left" => x--,
    _ => x = y = 0
};

Console.WriteLine("Current position");
Console.WriteLine($"X:{x}, Y:{y}");

// switch statement switch (dayNum)
// {
//   case >= 1 and <= 5:
//     result1 = "Week day";
//     break;
//   case 6 or 7:
//     result1 = "Weekend";
//     break;
//   default:
//     result1 = "Invalid day";
//     break;
// }
// // switch expressionstring result2 = dayNum switch{
//     >= 1 and <= 5 => "Week day",
//     6 or 7 => "Weekend",
//     _ => "Invalid day"};