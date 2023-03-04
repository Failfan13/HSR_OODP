public class Program
{
    public static void Main(string[] args)
    {
        Publication journal = new(
            "Feasibility Study on the Development of Advanced Humanoid Robots for Military Applications",
            "Skynet Research", "Scientific journal",
            new List<string>() {"Military officials",
                "Defense contractors", "Academics", "Researchers" })
        {
            Pages = 12, //Similar to journal.Pages = 12;
        };
        Book book = new(
            "978-0060254926",
            "Where the Wild Things Are",
            "Maurice Sendak",
            "HarperCollins",
            new List<string>() { "Children" }
        )
        {
            Pages = 48,
            PublicationDate = new DateTime(1963, 11, 13)
        };
        book.SetPrice(25, "EUR");

        // Magazine magazine = new(
        //     "Popular Mechanics",
        //     "Hearst Communications",
        //     "January 2021",
        //     new List<string>() { "Engineers",
        //         "Technology enthousiasts", "DIY enthousiasts" })
        // {
        //     Pages = 30
        // };

        // PrintInfo(new List<Publication>() { journal, book, magazine });
    }

    // private static void PrintInfo(List<Publication> publications)
    // {
    //     List<string> audiences = new() { "Engineers", "Researchers" };
    //     foreach (var p in publications)
    //     {
    //         Console.WriteLine(p.PublicationType);
    //         Console.WriteLine(p.ToString());
    //         Console.WriteLine(p.PublishedOn);
    //         foreach (string a in audiences)
    //         {
    //             Console.WriteLine($"Suitable for {a.ToLower()}: "
    //                 + p.IsSuitableForAudience(a));
    //         }
    //         if (p is Book)
    //         {
    //             Console.WriteLine($"Suitable for children: "
    //                 + (p as Book).IsSuitableForChild());

    //         }
    //         Console.WriteLine();
    //     }
    // }
}