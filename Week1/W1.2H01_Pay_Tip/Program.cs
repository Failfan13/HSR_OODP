class Program {
    static void Main() {
        int fee, choice, startFee, toMuch;
        var fees = new List<int> {5, 10, 20, 50};

        Console.WriteLine("What is the amount to pay?");

        startFee = fee = Convert.ToInt32(Console.ReadLine());

        while (fee > 0) {
            Console.WriteLine($"{fee} left to pay\nPay how much?\n1: 5\n2: 10\n3: 20\n4: 50");
            choice = Convert.ToInt32(Console.ReadLine());
            if (1 <= choice && choice <= fees.Count) {
                fee = fee - fees[choice - 1];
            }
        }

        if (fee < 0) {
            string tip = "";
            toMuch = Math.Abs(fee);
            while (tip is not "y" and not "n") {
                Console.WriteLine($"You paid {toMuch} too much. Give a tip? y/n");
                tip = Console.ReadLine()?.ToLower();
            };
            if (tip == "y") {
                startFee = startFee + toMuch;
            }
        }

        Console.WriteLine($"You have paid {startFee}");
    }
}