public class Program {
    public static void Main() {
        Library lib = new Library();
        lib.ListOfBooks = new List<Book> {new Book(1, "Yeet"), new Book(12, "Sus"), new Book(13, "mf")};
        lib.MaxSize = 4;

        lib.AddBook(40, "HoiHoi");
        Console.WriteLine(lib.FindBook(13));

        lib.ModifyBook(13, "dogass");

        lib.ModifyBook(14, "dogass2");

        foreach (var book in lib.ListOfBooks ) {
            Console.WriteLine($"{book.ID} {book.Title}");
        }
    }
}