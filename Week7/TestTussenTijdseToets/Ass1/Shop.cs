public static class Shop
{
    public static List<Item> Inventory = new();
    public const int MaxQuantity = 5;

    public static void AddItemToInventory(Item itemObj)
    {
        if (itemObj == null || itemObj.Quantity > MaxQuantity)
        {
            return;
        }

        if (!Inventory.Any(x => x.Name == itemObj.Name && x.Quantity == itemObj.Quantity))
        {
            Inventory.Add(itemObj);
        }
    }

    public static Item? BuyItem(string name, int quantity, double amountPaid)
    {
        Item itemFound = Inventory.Find(x => x.Name == name && x.Quantity == quantity && x.GetTotalPrice() == amountPaid);

        if (itemFound == null || itemFound.GetType() == typeof(int))
        {
            return null;
        }
        return itemFound;
    }
}