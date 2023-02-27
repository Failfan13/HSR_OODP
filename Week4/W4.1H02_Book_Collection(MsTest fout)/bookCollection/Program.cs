public class Program
{
    public static List<Book>? ListOfBooks;
    public static void Main()
    {
        ListOfBooks = JsonReadWriter.ReadFromJson();
        var quit = false;
        while (!quit)
        {
            Console.WriteLine("Book Collection:");
            foreach (var book in ListOfBooks.Select((v, i) => new { Value = v, Index = i + 1 }))
            {
                Console.Write($"{book.Index}. {book.Value.Title} by {book.Value.Author} ({book.Value.PublicationYear})\n");
            }
            Console.WriteLine(@"

What would you like to do?
+: add a new book
-: remove a book
A number: see information on this book
q: quit");
            var ans = Console.ReadLine();
            var ansNumber = 0;
            if (int.TryParse(ans, out int Value))
            {
                ansNumber = Convert.ToInt32(ans);
                ans = "true";
            }
            switch (ans)
            {
                case "-":
                    RemoveBook();
                    break;
                case "+":
                    AddBook();
                    break;
                case "true":
                    GetBook(ansNumber);
                    break;
                case "q":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

    }

    public static void RemoveAllBooks()
    {
        ListOfBooks.Clear();
        JsonReadWriter.WriteToJson(ListOfBooks);
    }

    public static void AddBook()
    {
        Console.WriteLine("Enter the title of the new book:");
        var title = Console.ReadLine();
        Console.WriteLine("Enter the author of the new book:");
        var author = Console.ReadLine();
        Console.WriteLine("Enter the publication year of the new book:");
        var publicYear = Console.ReadLine();
        if (!int.TryParse(publicYear, out int Value))
        {
            Console.WriteLine("Year is not in a valid format.");
            return;
        }
        var yearConverted = Convert.ToInt32(publicYear);
        ListOfBooks.Add(new Book(title, author, yearConverted));
        JsonReadWriter.WriteToJson(ListOfBooks);
    }

    public static void RemoveBook()
    {
        Console.WriteLine("Enter the number of the book to remove:");
        var bookString = Console.ReadLine();
        if (!int.TryParse(bookString, out int Value))
        {
            Console.WriteLine("Not an index.");
            return;
        }

        int bookNumber = Convert.ToInt32(bookString);

        if (1 < bookNumber & bookNumber >= ListOfBooks.Count())
        {
            try
            {
                ListOfBooks.Remove(ListOfBooks[bookNumber - 1]);
                JsonReadWriter.WriteToJson(ListOfBooks);
            }
            catch (Exception)
            {
                Console.WriteLine("Book does not exist.");
            }
            return;
        }
    }
    public static void GetBook(int bookIndex)
    {
        bookIndex = bookIndex - 1;
        try
        {
            Console.WriteLine($@"Title: {ListOfBooks[bookIndex].Title}
Author {ListOfBooks[bookIndex].Author}
Publication Year: {ListOfBooks[bookIndex].Author}");
        }
        catch (Exception)
        {
            Console.WriteLine("Book does not exist.");
        }
    }
}
