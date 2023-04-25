public class CountedItem
{
    public Item TheItem;
    public int Quantity;

    public CountedItem(Item theItem, int quantity)
    {
        TheItem = theItem;
        Quantity = quantity;
    }

    public string Info()
    {
        return Quantity + " " + (Quantity == 1 ? TheItem.Name : TheItem.NamePlural);
    }
}