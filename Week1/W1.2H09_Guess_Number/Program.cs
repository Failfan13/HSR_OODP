class Program {
    static void Main() {
        int guessMin, guessMax, guessNum, guessChoice = 0;
        string playAgain = "Y";
        Random rand = new Random(0);

        Console.WriteLine("Time to play Guess The Number!");

        while (playAgain == "Y") {
            Console.WriteLine("Give the minimum number:");
            guessMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the maximum number:");
            guessMax = Convert.ToInt32(Console.ReadLine());

            if (guessMin == guessMax) {
                Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
                guessMax++;
            } else if (guessMin > guessMax) {
                Console.WriteLine("The minimum is higher than the maximum. Switching values.");
                (guessMin, guessMax) = (guessMax, guessMin);
            }

            guessNum = rand.Next(guessMin, (guessMax + 1));

            while (guessNum != guessChoice) {
                Console.WriteLine($"Guess the number [{guessMin}-{guessMax}]");
                guessChoice = Convert.ToInt32(Console.ReadLine());
                if (guessNum < guessChoice) {
                    Console.WriteLine("Lower!");
                } else if (guessNum > guessChoice) {
                    Console.WriteLine("Higher!");
                }
            };

            Console.WriteLine($"{guessChoice} is correct!");

            Console.WriteLine("Do you wish to play another round? Y to continue");
            playAgain = Console.ReadLine().ToUpper();
        };

        Console.WriteLine("thank you for playing!");
    }
}
