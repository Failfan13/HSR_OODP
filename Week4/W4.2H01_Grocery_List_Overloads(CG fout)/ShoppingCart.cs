class ShoppingCart
{
    public List<GroupedShopItem> Groceries;

    public ShoppingCart() => Groceries = new List<GroupedShopItem>();

    public void AddItem(ShopItem item, int amount = 1)
    {
        for (var i = 0; i < amount; i++)
        {
            var tempItem = FindItem(item);
            if (tempItem != null)
            {
                Groceries[Groceries.IndexOf(tempItem)].Quantity++;
            }
            else
            {
                Groceries.Add(new GroupedShopItem(item));
            }
        }
    }

    public GroupedShopItem FindItem(ShopItem item)
    {
        var tempItem = Groceries.Find(i => i.Item.ID == item.ID);
        if (tempItem != null)
        {
            return tempItem;
        }
        else
        {
            return null;
        };
    }

    public string Contents()
    {
        string tempString = "";
        foreach (var prod in Groceries)
        {
            tempString += $"{prod.Item.Name} x {prod.Quantity}" + "\n";
        }
        return tempString;
    }

    public double TotalPrice()
    {
        double tempPrice = 0.0;
        foreach (var prod in Groceries)
        {
            tempPrice += (prod.Item.Price);
        }
        return tempPrice;
    }
}