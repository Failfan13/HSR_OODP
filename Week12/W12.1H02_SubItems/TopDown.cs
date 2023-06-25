public static class TopDown
{
    public static void Display<T>(Item<T> item) => Display(item, "");
    public static void Display<T>(Item<T> item, string format)
    {
        if (item == null)
        {
            Console.WriteLine("None");
            return;
        }

        Console.WriteLine($"{format} {item.Value}");
        if (item.SubItems == null)
            return;

        item.SubItems.ForEach(sub => Display(sub, format + "---"));
    }

    public static Item<T> Find<T>(Item<T> item, T key)
    {
        if (item.Value.Equals(key)) return item;

        if (item.SubItems != null)
        {
            foreach (Item<T> subItem in item.SubItems)
            {
                var foundItem = Find(subItem, key);
                if (foundItem != null)
                    return foundItem;
            }

        }

        return null;
    }
}