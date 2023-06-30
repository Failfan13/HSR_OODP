public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string Language { get; protected set; }

    public Book(string title, string author, string language)
    {
        Title = title;
        Author = author;
        Language = language;
    }

    public Book(string title, string author) : this(title, author, "EN") { }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLanguage: {Language}");
    }
}