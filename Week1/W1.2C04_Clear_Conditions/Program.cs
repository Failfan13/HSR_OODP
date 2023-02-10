int pass = 1234, pin;

for (var i = 3; i > 0; i--) {
    Console.WriteLine($"Enter your PIN\n{i} attempts left");
    pin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(pin);
    if (pin == pass) {
        Console.WriteLine("Correct!");
        break;
    } else if (i == 1) {
        Console.WriteLine("Your pass is confiscated.");
        break;
    }
}