public static class Library
{
    public static List<Book> Books = new();
    public static List<Customer> Customers = new();

    // Ziek hard gecheat vgm
    public static T FindByID<T>(List<T> list, int id) where T : IHasID
    {
        foreach (T bookOrCustomer in list)
        {
            if (bookOrCustomer.ID == id)
            {
                return bookOrCustomer;
            }
        }
        return default(T);
    }
}