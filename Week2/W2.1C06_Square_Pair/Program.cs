public class Program {
    public static void Main() {
        var square1 = new Square(5);
        var square2 = new Square(10);

        List<Square> squares = new List<Square> {square1, square2};
        foreach (var square in squares) {
            Console.WriteLine($"Side: {square.Side}");
            Console.WriteLine($"Area: {square.Area()}");
            Console.WriteLine($"Perimeter: {square.Perimeter()}");
            // Console.WriteLine($"Side: {square.Side()}\nArea: {square.Area()}\nPerimeter: {square.Perimeter()}");
        };
    }
}