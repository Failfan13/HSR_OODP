
using System;
using System.Buffers;
using System.Collections.Generic;

public class Program
{

    public static void Main(string[] args)
    {
        // switch (args[1])
        // {
        //     case "VisibleTest": VisibleTest(); return;
        //     case "HiddenTest": HiddenUtils.HiddenTest(); return;
        //     case "HiddenTestMap": HiddenUtils.HiddenTestMap(); return;
        //     default: throw new ArgumentException();
        // }
        VisibleTest();
    }
    public static void VisibleTest()
    {

        Tuple<int, int>[][] tupleArray = {
                                new Tuple<int, int>[] { Tuple.Create(2, 4), Tuple.Create(3, 4) },
                                new Tuple<int, int>[] { Tuple.Create(7, 8), Tuple.Create(3, 2), Tuple.Create(6, 9), Tuple.Create(5, 4)},
                                new Tuple<int, int>[] { Tuple.Create(3, 4), Tuple.Create(1, 1)},
                                new Tuple<int, int>[] { Tuple.Create(1, 5),Tuple.Create(3, 1), Tuple.Create(2, 0)}
                            };

        object[][] mixedArray = {
                                new DataEntryPair<int, int>[] { new (8, 4), new (3, 4) },
                                new DataEntryPair<int, int>[] { new (7, 2), new (3, 5), new (5, 1)},
                                new Tuple<int, int>[] { Tuple.Create(0, 4), Tuple.Create(9, 5)},
                                new Tuple<int, int>[] { Tuple.Create(3, 6),Tuple.Create(3, 7),Tuple.Create(7, 4) }
                            };


        Console.WriteLine("Visualisation jagged array tupleArray:");
        //PrintUtils.PrintTest(tupleArray);
        Console.WriteLine();
        var res = JaggedUtils.ToMultidimensionalArray(tupleArray);
        Console.WriteLine("Visualisation corresponding multidimensional array after applying the method to tupleArray:");
        //PrintUtils.PrintTest(res);
        Console.WriteLine();

        res = JaggedUtils.ToMultidimensionalArray(mixedArray);
        Console.WriteLine("Visualisation corresponding multidimensional array after applying the method to mixedArray:");
        //PrintUtils.PrintTest(res);
        Console.WriteLine();

        int row = 3;
        Console.WriteLine($"After transforming row: {row}");
        mixedArray[row] = JaggedUtils.FromTuple2DataEntryPairArray(mixedArray[row] as Tuple<int, int>[]);
        res = JaggedUtils.ToMultidimensionalArray(mixedArray);
        //PrintUtils.PrintTest(res);
        Console.WriteLine();
    }
}

