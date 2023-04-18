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

    public static Item? BuyItem(string n, int q, double p)
    {
        return Inventory.Find(x => x.Name == n && x.Quantity == q && x.GetTotalPrice() == p);
    }
}