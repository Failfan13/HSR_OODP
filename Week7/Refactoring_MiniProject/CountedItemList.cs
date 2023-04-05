public class CountedItemList
{
    // Advanced student: This could be a dictionary or a hash set
    public List<CountedItem> TheCountedItemList;

    public CountedItemList()
    {
        TheCountedItemList = new List<CountedItem>();
    }

    public string Info()
    {
        if (TheCountedItemList.Count == 0)
        {
            return "No items\n";
        }
        string s = "\n";
        foreach (var item in TheCountedItemList)
        {
            s += item.Info() + "\n";
        }
        return s;
    }

    public bool HasItem(int searchID)
    {
        // Advanced student: Find + lambda
        // return InventoryList.Find(item => item.Details.ID == searchID && item.Quantity > 0);
        foreach (var item in TheCountedItemList)
        {
            if (item.TheItem.ID == searchID)
            {
                return true;
            }
        }
        return false;
    }

    public bool HasAllItems(CountedItemList itemList)
    {
        foreach (var item in itemList.TheCountedItemList)
        {
            //Need to get the item so that you can access the quantity of the item in the field item list
            var foundItem = GetCountedItem(item.TheItem);
            if (foundItem == null || foundItem.Quantity < item.Quantity)
            {
                return false;
            }
        }
        return true;
    }

    public CountedItem GetCountedItem(Item searchItem)
    {
        // Advanced student: Find + lambda
        // return InventoryList.Find(item => item.Details.ID == searchID);
        foreach (var item in TheCountedItemList)
        {
            if (item.TheItem.ID == searchItem.ID)
            {
                return item;
            }
        }
        return null;
    }

    public void AddCountedItem(CountedItem additionalItem)
    {
        if (additionalItem != null)
        {
            CountedItem itemInInventory = GetCountedItem(additionalItem.TheItem);
            if (itemInInventory != null)
            {
                itemInInventory.Quantity += additionalItem.Quantity;
            }
            else
            {
                TheCountedItemList.Add(additionalItem);
            }
        }
    }

    public void AddItem(Item additionalItem)
    {
        AddCountedItem(new CountedItem(additionalItem, 1));
    }

    public void AddCountedItemList(CountedItemList additionalItems)
    {
        foreach (var item in additionalItems.TheCountedItemList)
        {
            AddCountedItem(item);
        }
    }

    public void RemoveCountedItem(CountedItem itemToRemove)
    {
        if (itemToRemove != null && HasItem(itemToRemove.TheItem.ID))
        {
            CountedItem itemInInventory = GetCountedItem(itemToRemove.TheItem);
            if (itemInInventory != null)
            {
                itemInInventory.Quantity -= itemToRemove.Quantity;
                if (itemInInventory.Quantity <= 0)
                {
                    TheCountedItemList.Remove(itemInInventory);
                }
            }
        }
    }

    public void RemoveCountedItemList(CountedItemList itemsToRemove)
    {
        foreach (var item in itemsToRemove.TheCountedItemList)
        {
            RemoveCountedItem(item);
        }
    }

    // The item selected should never be the Adventurers pass 
    // as you cannot get it back and you need it to win the game
    public Item SelectRandomItem()
    {
        if (TheCountedItemList.Count > 0)
        {
            if (TheCountedItemList.Count == 1 && TheCountedItemList[0].TheItem.ID == World.ITEM_ID_ADVENTURER_PASS)
            {
                return null;
            }
            var item = TheCountedItemList[World.RandomGenerator.Next(0, TheCountedItemList.Count)].TheItem;
            // Keep picking a random Item until it is not the adventurer pass
            while (item.ID == World.ITEM_ID_ADVENTURER_PASS)
            {
                item = TheCountedItemList[World.RandomGenerator.Next(0, TheCountedItemList.Count)].TheItem;
            }
            return item;
        }
        return null;
    }

    public CountedItemList SelectMultipleRandomItems()
    {
        CountedItemList randomItems = new CountedItemList();
        foreach (var item in TheCountedItemList)
        {
            if (World.RandomGenerator.Next(2) == 0)
            {
                randomItems.AddItem(item.TheItem);
            }
        }
        return randomItems;
    }
}