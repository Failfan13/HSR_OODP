public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string Language { get; set; }

    public Book(string t, string a, string l)
    {
        Title = t;
        Author = a;
        Language = l;
    }

    public Book(string t, string a) : this(t, a, "EN") { }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}\n Author: {Author}\n Language: {Language}");
    }
}