public class Library
{
    public Dictionary<string, Book> BookInventory = new Dictionary<string, Book>();
    public Stack<Book> RemovedBooks = new Stack<Book>();

    public void AddBook(string title, string author, string genre, BookCategory category)
    {
        BookInventory.Add(title, new Book(title, author, genre, category));
    }

    public List<Book> SearchByGenre(string genre) => BookInventory.Where(b => b.Value.Genre == genre).Select(b => b.Value).ToList();

    public void RemoveBook(string title)
    {
        if (BookInventory.Any(b => b.Key == title))
        {
            RemovedBooks.Push(BookInventory[title]);

            BookInventory.Remove(title);
        }
    }

    public void UndoRemove()
    {
        if (RemovedBooks.Count != 0)
        {
            var book = RemovedBooks.Pop();
            BookInventory.Add(book.Title, book);
        }

    }
}