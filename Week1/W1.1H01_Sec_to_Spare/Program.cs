Console.WriteLine("How many seconds?");
int seconds = Convert.ToInt32(Console.ReadLine());

int h, m, s;
h = m = s = 0;

h = seconds / 3600;
m = (seconds % 3600) / 60;
s = (seconds % 3600) % 60;

Console.WriteLine($"Hours: {h}");
Console.WriteLine($"Minutes: {m}");
Console.WriteLine($"Seconds left: {s}");