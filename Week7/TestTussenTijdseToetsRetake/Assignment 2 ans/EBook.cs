public class EBook : Book
{
    public EBook(string title, string author)
        : base(title, author, "EN") { }
    public EBook(string title, string author, string language)
        : base(title, author, language) { }

    public void UpdateLanguage(string language) => Language = language;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("EBook");
    }
}