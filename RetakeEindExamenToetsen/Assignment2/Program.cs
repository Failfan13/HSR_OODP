public class Program
{

    public static void Main(string[] args)
    {
        // switch (args[1])
        // {
        //     case "VisibleTest": VisibleTest(); return;
        //     case "HiddenTestNull": HiddenUtils.HiddenTestNull(); return;
        //     case "HiddenTestRows": HiddenUtils.HiddenTestRows(); return;
        //     case "HiddenTestCols": HiddenUtils.HiddenTestCols(); return;
        //     case "HiddenTestRowsCols": HiddenUtils.HiddenTestRowsCols(); return;
        //     default: throw new ArgumentException();
        // }
        VisibleTest();
    }
    public static void VisibleTest()
    {

        object[][] text = {
                        new string[]{ "cat"   ,"is" ,"an" ,"animal"                },
                        new object[]{ "is"    ,2.5  ,"ant"                         },
                        new string[]{ "a"     ,"not","is" ,"an"     ,"animal" ,"!" },
                        new string[]{ "feline","is" ,"an" ,"animal"                },
                        new string[]{ ""      ,"is" ,"ant","insect?"               }
        };

        Console.WriteLine("Visualisation sentences in text read horizontally:");
        //here "<object>" is used to make sure CreateSentences is a generic method
        PrintUtils.PrintTest(TextUtils.CreateSentences<object>(text).Item1, 0);
        Console.WriteLine();
        Console.WriteLine("Visualisation sentences in text read vertically:");
        PrintUtils.PrintTest(TextUtils.CreateSentences(text).Item2, 1);
        Console.WriteLine();
    }
}