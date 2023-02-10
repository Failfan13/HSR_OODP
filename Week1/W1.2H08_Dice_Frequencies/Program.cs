Random rand = new(0);
int howManyTimes = 500, dieSides = 6, rollTotal = 0;

List<List<int>> results = new();
for (int i = 0; i < howManyTimes; i++)
{
    List<int> rollResults = new();
    for (int j = 0; j < 2; j++)
    {
        rollResults.Add(rand.Next(1, dieSides + 1));
    }
    results.Add(rollResults);
}

List<string> freqs = new()
{
    " 2: ",
    " 3: ",
    " 4: ",
    " 5: ",
    " 6: ",
    " 7: ",
    " 8: ",
    " 9: ",
    "10: ",
    "11: ",
    "12: ",
};

for (int g = 0; g < results.Count; g++) {
    for (int r = 0; r < results[g].Count; r++) {
        rollTotal += results[g][r];
    }
    freqs[rollTotal - 2] = freqs[rollTotal - 2] += "|";
    rollTotal = 0;
}

foreach (var freq in freqs) {
    Console.WriteLine(freq);
}

/*
 * Your code goes here.
 * List 'results' is a nested List. Each inner List contain two numbers.
 * For each inner List, you need to sum the two numbers, then update 'freqs'.
 * For example, if the sum of the two dice is 7, add a pipe to the string "7: ".
 */

/*
class Program {
    static void Main() {
        var freqDict = new Dictionary<int, string> ();
        var sortedDict = new Dictionary<int, string> ();

        for (int i = 0; i < 500; i++) {
            Random rand = new Random();
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            int roll = dice1 + dice2;

            if (!freqDict.ContainsKey(roll)) {
                freqDict.Add(roll, "");
            };

            freqDict[roll] = freqDict[roll] + "|";
        };

        foreach(KeyValuePair<int, string> pair in freqDict) {
            string key = Convert.ToString(pair.Key);
            key = (key.Length > 1 ? $"{key}" : $" {key}");
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        };

        // var list = freqDict.Keys.ToList();
        // list.Sort();

        // foreach (var key in list) {
        //     sortedDict.Add(key, freqDict[key]);
        // }
    }
}*/