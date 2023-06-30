public static class Shop
{
    public static List<Item> Inventory = new List<Item>();
    public const int MaxQuantity = 5;

    public static void AddItemToInventory(Item item)
    {
        if (item == null || item.Quantity > MaxQuantity) return;

        if (!Inventory.Any(i => i.Name == item.Name && i.Quantity == item.Quantity))
        {
            Inventory.Add(item);
        }
    }

    public static Item BuyItem(string name, int quantity, double paid)
    {
        return Inventory.Find(i => i.Name == name && i.Quantity == quantity && i.GetTotalPrice() == paid);
    }
}