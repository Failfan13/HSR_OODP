public class Program
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "TestAddBook":
                TestAddBook();
                break;
            case "TestRemoveBook":
                TestRemoveBook();
                break;
            case "TestUndoRemove":
                TestUndoRemove();
                break;
            case "TestSearchByGenreUnordered":
                TestSearchByGenreUnordered();
                break;
            case "TestMultipleUndoRemove":
                TestMultipleUndoRemove();
                break;
            default:
                Console.WriteLine("No test found. Wrong argument");
                break;
        }

        // call all methods to test the functionality
        // TestAddBook();
        // TestRemoveBook();
        // TestUndoRemove();
        // TestMultipleUndoRemove();
        // TestSearchByGenreUnordered();

    }


    public static void TestAddBook()
    {
        Library library = new Library();

        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", BookCategory.Adult);
        if (GetBookByTitle("The Great Gatsby", library) != null)
        {
            Console.WriteLine("Test passed - the book was added to the inventory");
        }
        else
        {
            Console.WriteLine("Test failed - the book was not added to the inventory");
        }
        //Expected output:
        //Test passed - the book was added to the inventory
    }

    public static void TestRemoveBook()
    {
        Library library = new Library();

        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", BookCategory.Adult);
        library.RemoveBook("The Great Gatsby");
        if (GetBookByTitle("The Great Gatsby", library) == null)
        {
            Console.WriteLine("Test passed - the book was removed from the inventory");
        }
        else
        {
            Console.WriteLine("Test failed - the book was not removed from the inventory");
        }
        //expected output:
        //Test passed - the book was removed from the inventory
    }


    public static void TestUndoRemove()
    {
        Library library = new Library();

        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", BookCategory.Adult);
        library.AddBook("Pride and Prejudice", "Jane Austen", "Romance", BookCategory.Adult);

        library.RemoveBook("The Great Gatsby");
        library.UndoRemove();
        if (GetBookByTitle("The Great Gatsby", library) != null)
        {
            Console.WriteLine("Test passed - the removed book is back in the inventory");
        }
        else
        {
            Console.WriteLine("Test failed - the removed book is not back in the inventory");
        }

        //Doing one more with a hidden name to prevent cheating
        HiddenTests.TestUndoRemove();



        //expected output:
        //Test passed - the removed book is back in the inventory
        //Test passed - the removed book is back in the inventory
    }


    public static void TestMultipleUndoRemove()
    {
        Library library = new Library();

        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", BookCategory.Adult);
        library.AddBook("Pride and Prejudice", "Jane Austen", "Romance", BookCategory.Adult);

        library.RemoveBook("The Great Gatsby");
        library.RemoveBook("Pride and Prejudice");
        library.UndoRemove();

        //seperate if to test order of books
        if (GetBookByTitle("Pride and Prejudice", library) != null)
        {
            library.UndoRemove();
            if (GetBookByTitle("The Great Gatsby", library) != null)
            {
                Console.WriteLine("Test passed - the removed books are back in the inventory");
            }
            else
            {
                Console.WriteLine("Test failed - the removed books are not back in the inventory");
            }
        }
        else
        {
            Console.WriteLine("Test failed - the removed books are not back in the inventory");
        }

        //Doing one more with a hidden name to prevent cheating
        HiddenTests.TestMultipleUndoRemove();





        //expected output:
        //Test passed - the removed books are back in the inventory
        //Test passed - the removed books are back in the inventory
    }



    public static void TestSearchByGenreUnordered()
    {
        Library library = new Library();

        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", BookCategory.Adult);
        library.AddBook("To Kill a Mockingbird", "Harper Lee", "Fiction", BookCategory.Adult);
        library.AddBook("1984", "George Orwell", "Fiction", BookCategory.Adult);
        library.AddBook("The Catcher in the Rye", "J.D. Salinger", "Fiction", BookCategory.Adult);
        library.AddBook("Pride and Prejudice", "Jane Austen", "Romance", BookCategory.Adult);

        List<Book> fictionBooks = library.SearchByGenre("Fiction");
        string result = $"We've added 4 books with the same genre. We searched for this genre and found {fictionBooks.Count} books.";
        Console.WriteLine(result);

        //Doing one more with hidden names to prevent cheating
        HiddenTests.TestSearchByGenreUnordered();


        //expected output:
        //We've added 4 books with the same genre. We searched for this genre and found 4 books.
        //We've added 2 books with the same genre. We searched for this genre and found 2 books.
    }




    //Extra methods to help with testing
    public static Book GetBookByTitle(string title, Library li)
    {

        li.BookInventory.TryGetValue(title, out Book book);
        return book;
    }


}