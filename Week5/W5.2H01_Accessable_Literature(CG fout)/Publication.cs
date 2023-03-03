class Publication
{
    public string Name, Author, Publisher, PublicationType;
    public List<string> Audiences;
    private int _pages;
    public DateTime PublicationDate;

    public Publication(string name, string author, string publisher, List<string> audience)
    {
        Name = name;
        Author = author;
        Publisher = publisher;
        Audiences = audience;
        PublicationType = "";
    }

    public int Pages
    {
        get => _pages;
        set => _pages = (value <= 0 ? Pages : value);
    }
    public string PublishedOn
    {
        get => (PublicationDate != DateTime.MinValue ?
            PublicationDate.ToString("dd-MM-yyyy") :
            "not published yet");
        set { }
    }
    public string IsPublished
    {
        get => IsPublished;
        set => IsPublished = (value != null ? value : null);
    }

    public string IsSuitableForAudience(string audience)
    {
        if (Audiences.Find(x => x == audience) == audience)
        {
            return "True";
        }
        return "False";
    }

    public override string ToString()
    {
        return $"{Name}, {_pages} pages, {PublishedOn}";
    }
}