class Book
{
    public int ID;
    public string Title;

    public Book(int id) : this(id, "Title unknown") { }

    public Book(int id, string title)
    {
        this.ID = id;
        this.Title = title;
    }

    public string Info()
    {
        return $"ID = {ID}, Title = {Title}";
    }
}