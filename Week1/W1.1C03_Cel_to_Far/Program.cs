int temp = Convert.ToInt32(Console.ReadLine());

double fahr = ((double)temp*9/5) + 32;

Console.WriteLine($"{temp} C = {fahr} F");
Console.WriteLine($"Rounded down that is {(int)fahr} F");