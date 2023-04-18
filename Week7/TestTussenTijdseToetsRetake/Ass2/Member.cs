public class Member : Person
{
    public int NumberOfBooksBorrowed { get; private set; }
    public override string Name
    {
        get => base.Name + "(member)";
    }
    public Member(string n, int a) : base(n, a)
    {
        NumberOfBooksBorrowed = 0;
    }

    public void BorrowBook(Book b)
    {
        if (b == null) return;
        if (b.GetType() == typeof(EBook))
        {
            Console.WriteLine($"{Name} has borrowed the EBook {b.Title} by {b.Author}");
        }
        else
        {
            if (NumberOfBooksBorrowed < 3)
            {
                NumberOfBooksBorrowed++;
                Console.WriteLine($"{Name} has borrowed {b.Title} by {b.Author}");
            }
            else
            {
                Console.WriteLine($"{Name} has already borrowed the maximum number of books");
            }
        }
    }

    public override string ToString() => base.ToString() + $"\n Borrowed book: {NumberOfBooksBorrowed}";

}