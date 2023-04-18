public class EBook : Book
{
    public EBook(string t, string a, string l) : base(t, a, l) { }

    public EBook(string t, string a) : base(t, a) { }

    public void UpdateLanguage(string l) => base.Language = l;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("EBook");
    }
}