double day, month;
day = month = 0;

double dayMonth;

Console.WriteLine("What is the month? 1-12");
month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the day? 1-31");
day = Convert.ToInt32(Console.ReadLine());

dayMonth = month + day/100;

string monthName = month switch {
    1 => "January",
    2 => "February",
    3 => "March",
    4 => "April",
    5 => "May",
    6 => "June",
    7 => "July",
    8 => "August",
    9 => "September",
    10 => "October",
    11 => "November",
    12 => "December"
};

string season = dayMonth switch {
    <= 3.20 => "Winter",
    <= 6.20 => "Spring",
    <= 9.20 => "Summer",
    <= 12.20 => "Autumn",
    _ => "Winter"
};

Console.WriteLine($"On {day}-{month} it is {season}");