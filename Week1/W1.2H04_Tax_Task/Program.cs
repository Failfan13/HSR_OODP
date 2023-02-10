class Program {
    static void Main() {
        double balance, years, interest, remainder1 = 0, remainder2 = 0, remainder = 0, taxes = 0, yearTax = 0, currentYear = 1, balanceInterest;
        balance = Convert.ToInt32(Console.ReadLine());
        interest = Convert.ToInt32(Console.ReadLine());
        years = Convert.ToInt32(Console.ReadLine());

        do{
            balanceInterest = balance * interest / 100;
            balance += balanceInterest;
            remainder = balance;

            if (remainder > 50000) {
                remainder1 = remainder - 50000;
                remainder = 50000;
                if (remainder1 > 50000) {
                    remainder2 = remainder1 -50000;
                    remainder1 = 50000;
                }
            }
            yearTax = (remainder1 * 1.5 / 100) + (remainder2 * 3 / 100);
            balance -= yearTax;
            taxes += yearTax;
            currentYear++;
        }while(currentYear <= years);
        Console.WriteLine($"Balance after {years} years: {(int)balance}\nAmount of taxes paid: {(int)taxes}");
    }
}

// Code van Tim

// double balance = Convert.ToDouble(Console.ReadLine());
// int ipercent = Convert.ToInt32(Console.ReadLine());
// int years = Convert.ToInt32(Console.ReadLine());
// double bracket0 = 0;
// double remainder1 = 0;
// double remainder2 =  0;
// double taxtopay = 0;
// double totaltax = 0;
// int curryear = 1;

// do
// {
//     double intam = balance * ipercent / 100;
//     balance += intam;
//     bracket0 = balance;
//     if (bracket0 > 50000)
//     {
//         remainder1 = bracket0 - 50000;
//         bracket0 = 50000;
//         if (remainder1 > 50000)
//         {
//             remainder2 = remainder1 -50000;
//             remainder1 = 50000;
//         }
//     }

//     taxtopay = (remainder1 * 1.5 / 100) + (remainder2 * 3 / 100);
//     balance -= taxtopay;
//     totaltax += taxtopay;
//     curryear += 1;
// } 
// while (curryear <= years);
// Console.WriteLine($"Balance after {years} years: {(int)balance}");
// Console.WriteLine($"Amount of taxes paid: {(int)totaltax}");
