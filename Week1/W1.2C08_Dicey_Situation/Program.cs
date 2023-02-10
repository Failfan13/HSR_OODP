// https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
class Program {
    static void Main(){
        Random rnd = new Random();
        for (var i = 0; i < 10; i++) {
            Console.WriteLine(rnd.Next(1, 7));
        }
    }
}
