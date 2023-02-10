Console.WriteLine("Enter an age");
int age = Convert.ToInt32(Console.ReadLine());

string type = age switch{
    < 0 => "invalid",
    <= 12 => "a child",
    <= 19 => "a teenager",
    <= 150 => "an adult",
    _ => "invalid"
};

Console.WriteLine($"Age {age}: {type}");