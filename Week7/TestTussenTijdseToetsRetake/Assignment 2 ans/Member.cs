public class Member : Person
{
    public override string Name { get => $"{base.Name} (member)"; }
    public int NumberOfBooksBorrowed { get; private set; }

    public Member(string name, int age) : base(name, age) { }

    public void BorrowBook(Book book)
    {
        if (book == null)
            return;
        if (book is EBook)
        {
            Console.WriteLine($"{Name} has borrowed the Ebook {book.Title} by {book.Author}");
            return;
        }
        if (NumberOfBooksBorrowed >= 3)
        {
            Console.WriteLine($"{Name} has already borrowed the maximum number of books");
            return;
        }

        NumberOfBooksBorrowed++;
        Console.WriteLine($"{Name} has borrowed {book.Title} by {book.Author}");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nBorrowed books: {NumberOfBooksBorrowed}";
    }
}