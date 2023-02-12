class GroupedShopItem {
    public ShopItem Item;
    public int Quantity;

    public GroupedShopItem(ShopItem item) => (Item, Quantity) = (item, 1);
}