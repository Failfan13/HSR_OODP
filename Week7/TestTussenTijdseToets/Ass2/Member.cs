public class Member : Person
{
    private string _name = "";
    new public string Name
    {
        get => _name;
        set
        {
            _name = value + " (member)";
        }
    }

    public int NumberOfBooksBorrowed { get; private set; }

    public Member(string name, int age)
        : base(name, age)
    {
        Name = base.Name;
        NumberOfBooksBorrowed = 0;
    }

    public void BorrowBook(Book bookObj)
    {
        if (bookObj == null)
        {
            return;
        }
        if (bookObj.GetType() == typeof(EBook))
        {
            Console.WriteLine($"{Name} has borrowed the Ebook {bookObj.Title} by {bookObj.Author}");
        }
        else
        {
            if (NumberOfBooksBorrowed < 3)
            {
                NumberOfBooksBorrowed++;
                Console.WriteLine($"{Name} has borrowed {bookObj.Title} by {bookObj.Author}");
            }
            else
            {
                Console.WriteLine($"{Name} has already borrowed the maximum number of books");
            }
        }
    }

    public override string ToString() => $"Name: {Name}\nAge: {base.Age}\nBorrowed books: {NumberOfBooksBorrowed}";
}