public class EBook : Book
{
    public EBook(string title, string author, string language)
        : base(title, author, language) { }

    public EBook(string title, string author) : this(title, author, "EN") { }

    public void UpdateLanguage(string newLanguage) => Language = newLanguage;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("EBook");
    }
}