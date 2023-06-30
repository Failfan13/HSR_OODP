public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }

    public Book(string title, string author, string genre, BookCategory category)
    {
        Title = title;
        Author = author;
        Genre = genre;
    }
}