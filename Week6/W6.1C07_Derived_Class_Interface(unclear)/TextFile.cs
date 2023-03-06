class TextFile : File, IPrintable
{
    private string _name;
    public TextFile(string fileName) : base(fileName)
    {
        Name = fileName;
        Console.WriteLine(Name);
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }
}