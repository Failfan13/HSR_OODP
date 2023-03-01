public class Program
{
    public static void Main()
    {
        List<Product> products = new()
        {
            new Product("Mug", 3, 15),
            new Clothes("Shirt", 25, 20, "L", "Cotton"),
            new Electronics("Screen", 200, 10, "Samsung", "LS27BM500EU"),
            new Computer("Laptop", 800, 10, "Dell", "Inspiron"),
        };

        Console.WriteLine("Mugs");
        products[0].Sell(10);
        products[0].Sell(10);

        Console.WriteLine("\nShirts");
        products[1].Sell(20);
        products[1].Sell(1);

        Console.WriteLine("\nScreens");
        products[2].Sell(10);
        products[2].Sell(10);
        products[2].Sell(11);

        Console.WriteLine("\nLaptops");
        products[3].Sell(10);
        products[3].Sell(5);
        products[3].Sell(3);
        products[3].Sell(6);

        Console.WriteLine("\nTest each class' ToString()");
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }
}