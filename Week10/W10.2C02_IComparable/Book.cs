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

    public int CompareTo(object obj)
    {
        Book objBook = obj as Book;
        if (obj == null) return 1;

        int year = Year.CompareTo(objBook.Year);
        if (year != 0) return year;

        int auth = Author.CompareTo(objBook.Author);
        if (auth != 0) return auth;

        int title = Title.CompareTo(objBook.Title);
        if (title != 0) return title;

        return 0;
    }
}