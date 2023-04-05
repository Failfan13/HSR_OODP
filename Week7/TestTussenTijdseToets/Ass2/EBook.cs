public class EBook : Book
{

    public EBook(string title, string author, string language)
        : base(title, author, language) { }

    public EBook(string title, string author)
        : base(title, author) { }

    public void UpdateLanguage(string lang)
    {
        base.Language = lang;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Title: {base.Title}\nAuthor: {base.Author}\nLanguage: {base.Language}\nEBook");
    }
}