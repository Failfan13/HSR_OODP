public class Library {
    public List<Book> Books;
    public int MaxSize;

    public bool AddBook(int id, string title) {
        if (Books.Count < MaxSize) {
            Books.Add(new Book(id, title));
            return true;
        } else {
            return false;
        };
    }

    public dynamic FindBook(int id) {
        try {
            var tempBook = Books.First(book => book.ID == id);
            return tempBook;
        } catch (Exception e) {
            return null;
        }
        
    }

    public void ModifyBook(int id, string title) {
        var tempBook = FindBook(id);
        if (tempBook != null) {
            Books[Books.IndexOf(tempBook)] = new Book(id, title);
        }
    }
}