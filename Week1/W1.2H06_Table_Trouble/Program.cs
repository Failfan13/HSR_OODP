class Program {
    static void Main() {
        int choiceNum, tableNum, sum;
        string table = "", tempTable = "";

        choiceNum = Convert.ToInt32(Console.ReadLine());
        if (choiceNum > 9) {
            tableNum = 9;
        } else if (choiceNum < 2) {
            tableNum = 2;
        } else {
            tableNum = choiceNum;
        }

        table += $"  |";
        for (int d = 1; d <= tableNum; d++) {
            if (d.ToString().Length > 1) {
                table += $"  {d}";
            } else if (d.ToString().Length > 2) {
                table += $" {d}";
            } else {
                table += $"   {d}";
            }
        };
        table += "\n";
        table += "----";

        for (int i = 1; i <= tableNum; i++) {
            tempTable += $"{i} |";

            for (int h = 1; h <= tableNum; h++) {
                sum = i * h;
                if (sum.ToString().Length > 1) {
                    tempTable += $"  {sum}";
                } else if (sum.ToString().Length > 2) {
                    tempTable += $" {sum}";
                } else {
                    tempTable += $"   {sum}";
                }
            };
            tempTable += "\n";
            table += "----";
        };

        table = table + ("\n" + tempTable);
        Console.WriteLine(table);
    }
}
