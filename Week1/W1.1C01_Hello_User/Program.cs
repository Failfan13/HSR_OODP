Console.WriteLine("Enter last name");
string? lastName = Console.ReadLine();
Console.WriteLine("Enter initials");
string? initials = Console.ReadLine();
char initials2 = Convert.ToChar(initials);
Console.WriteLine($"Welcome to the course, {initials} {lastName}. We will watch your career with great interest.");
