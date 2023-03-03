class Book : Publication
{
    public string ISBN = "", PriceType = "";
    public int Price;
    public Book(string isbn, string name, string author, string publisher, List<string> audience)
        : base(name, author, publisher, audience)
    {
        base.PublicationType = "Book";
        ISBN = isbn;
    }

    public void SetPrice(int price, string type)
    {
        PriceType = type;
        Price = price;
    }
    public bool IsSuitableForChild()
    {
        if (Audiences.Find(x => x == "Children") == "Children")
        {
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        return $"{ISBN}, {base.Author}, {base.ToString()}, {PriceType} {Price}";
    }
}