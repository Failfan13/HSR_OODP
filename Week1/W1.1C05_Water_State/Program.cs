Console.WriteLine("What is the temperature of the water?");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 100) {
    Console.WriteLine($"At {temp} degrees Celsius, the water will be gas");
} else if (temp >= 0.1) { 
    Console.WriteLine($"At {temp} degrees Celsius, the water will be liquid");
} else {
    Console.WriteLine($"At {temp} degrees Celsius, the water will be solid");
}
