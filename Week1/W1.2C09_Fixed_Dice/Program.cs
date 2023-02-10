class Program {
    static void Main() {
        Random rnd = new Random(1);
        for (var i = 0; i < 10; i++) {
            Console.WriteLine(rnd.Next(1,7));
        }
    }
}