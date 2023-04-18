public static class Shop
{
    public static List<Item> Inventory = new();
    public const int MaxQuantity = 5;

    public static void AddItemToInventory(Item item)
    {
        if (item == null)
            return;
        if (item.Quantity > MaxQuantity)
            return;

        foreach (var inventoryItem in Inventory)
        {
            if (item.Name == inventoryItem.Name &&
                item.Quantity == inventoryItem.Quantity)
                return;
        }
        Inventory.Add(item);
    }

    public static Item BuyItem(string itemName, double quantity, double amountPaid)
    {
        foreach (var inventoryItem in Inventory)
        {
            if (itemName == inventoryItem.Name
                && quantity == inventoryItem.Quantity
                && amountPaid == inventoryItem.GetTotalPrice())
                return inventoryItem;
        }
        return null;
    }
}