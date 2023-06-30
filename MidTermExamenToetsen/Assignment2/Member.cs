public class Member : Person
{
    public override string Name
    {
        get => base.Name + " (member)";
    }
    public int NumberOfBooksBorrowed { get; private set; }

    public Member(string name, int age)
        : base(name, age)
    {
        NumberOfBooksBorrowed = 0;
    }

    public void BorrowBook(Book book)
    {
        if (book == null) return;

        if (book.GetType() == typeof(EBook))
        {
            Console.WriteLine($"{Name} has borrowed the Ebook {book.Title} by {book.Author}");
            return;
        }

        if (NumberOfBooksBorrowed < 3)
        {
            Console.WriteLine($"{Name} has borrowed {book.Title} by {book.Author}");

            NumberOfBooksBorrowed++;
        }
        else
        {
            Console.WriteLine($"{Name} has already borrowed the maximum number of books");
        }
    }

    public override string ToString() => base.ToString() + $"\nBorrowed books: {NumberOfBooksBorrowed}";
}