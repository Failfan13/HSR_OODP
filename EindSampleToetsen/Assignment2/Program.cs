
using System;
public class Program
{

    public static void Main(string[] args)
    {


        switch (args[1])
        {
            case "VisibleTest": VisibleTest(); return;
            case "HiddenTestTotals": HiddenUtils.HiddenTestTotals(); return;
            case "HiddenTestPortions": HiddenUtils.HiddenTestPortions(); return;
            default: throw new ArgumentException();
        }
    }
    public static void VisibleTest()
    {

        Tuple<string, double>[][] bills = {
                        new Tuple<string, double>[] { Tuple.Create("Linguine al Pesto", 14.50), Tuple.Create("Caponata", 8.5) },
                        new Tuple<string, double>[] { Tuple.Create("Linguine al Pesto", 14.50), Tuple.Create("Caponata", 8.5), Tuple.Create("Espresso", 2.5)},
                        new Tuple<string, double>[] { Tuple.Create("Linguine al Pesto", 14.50)},
                        new Tuple<string, double>[] { Tuple.Create("Linguine al Pesto", 14.50), Tuple.Create("Caponata", 8.5)}
                    };

        var dishesPortions = ComputingUtils.ComputePortions(bills);
        PrintUtils.PrintTest(dishesPortions);
        var computedBills = ComputingUtils.ComputeTotals(bills);
        PrintUtils.PrintTest(computedBills);

    }
}

