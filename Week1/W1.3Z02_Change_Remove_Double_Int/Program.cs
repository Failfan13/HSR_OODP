double input = Convert.ToDouble(Console.ReadLine());

int Euro, Cents;

Euro = (int)input;

Cents = Convert.ToInt32(input.ToString().Replace($"{Euro}.", ""));

Console.WriteLine($"Euros: {Euro}\nCents: {Cents}");