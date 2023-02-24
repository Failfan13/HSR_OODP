static class GameTools {
    public static bool ReturnCount = true;
    static Random rand = new Random();
    static Dictionary<int, int> diceDict = new Dictionary<int, int> ();

    static GameTools() {}

    public static string CoinFlip(int flips) {
        int heads = 0;
        int tails = 0;
        string outcome = "";
        for (var i = 0; i < flips; i++) {
            if (!ReturnCount) {
                if (rand.Next(1,3) == 1)
                    outcome += "Heads\n";
                else
                    outcome += "Tails\n";
            } else {
                if (rand.Next(1,3) == 1)
                    ++heads;
                else
                    ++tails;
                outcome = $"Heads: {heads}\nTails: {tails}";
            }
        }
        return outcome;
    }

    public static string DiceRoll(int sides, int rolls) {
        if (sides < 3) 
            return "Invalid number of die sides";
        string outcome = "";
        for (var i = 1; i < rolls+1; i++) {
            var tempRoll = rand.Next(1, sides+1);
            if (!ReturnCount) {
                outcome += $"Roll {i}: {tempRoll}\n";
            } else {
                if (diceDict.ContainsKey(tempRoll)) {
                    diceDict[tempRoll]++;
                } else {
                    diceDict.Add(tempRoll, 1);
                }
            }
        }
        var diceDictOrder = diceDict.OrderBy(x => x.Key);
        foreach (var key in diceDictOrder) 
            outcome += $"{key.Key} was rolled {key.Value} times\n";
        return outcome;
    }
}