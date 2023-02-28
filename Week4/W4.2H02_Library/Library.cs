class Library
{
    public List<Book> Books;

    public Library() : this(new()) { }
    public Library(List<Book> books)
    {
        this.Books = books;
    }

    public void AddBook(Book bookObj)
    {
        Books.Add(bookObj);
    }
    public void AddBook(int id, string title)
    {
        Books.Add(new Book(id, title));
    }

    public Book FindBook(int id)
    {
        return Books.Find(x => x.ID == id);
    }

    public Book FindBook(string id)
    {

        if (int.TryParse(id, out int Value))
        {
            return Books.Find(x => x.ID == Convert.ToInt32(id));
        }
        Console.WriteLine($"ID = {id}: not a valid book ID. Input string was not in a correct format.");
        return null;
    }
}