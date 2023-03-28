public class Book : IComparable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public int CompareTo(object? obj)
    {
        Book book = obj as Book;
        if (book.GetType().GetProperties().Length == 0) return 1;

        if (book.GetType().GetProperties().Length != 0)
        {
            return Year.CompareTo(book.Year);
        }
        return 0;
    }
}