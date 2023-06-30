using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "StaticClass": TestStaticClass(); return;
            case "Readonly": TestReadonlyFields(); return;
            case "Const": TestConstFields(); return;
            case "FunItem": TestItemFunctionality(); return;
            case "Inventory": TestShopInventory(); return;
            case "Buy": TestShopBuy(); return;
            default: throw new ArgumentException();
        }
    }

    private static void TestStaticClass()
    {
        Type type = typeof(Shop);
        Console.WriteLine("Shop is a static class: "
            + (type.IsAbstract && type.IsSealed));
    }

    private static void TestReadonlyFields()
    {
        Console.WriteLine("Name is a read-only field: " +
            typeof(Item).GetField("Name", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance).IsInitOnly);
    }

    private static void TestConstFields()
    {
        Console.WriteLine("MaxQuantity is a constant field: " +
            typeof(Shop).GetField("MaxQuantity", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance).IsLiteral);
    }

    private static void TestItemFunctionality()
    {
        Item bread = new("Bread", 2.0, 4);
        Console.WriteLine("Bread total price: " + bread.GetTotalPrice());

        Console.WriteLine("Increasing price and quantity of bread...");
        bread.PricePerUnit += 0.5;
        bread.Quantity++;
        Console.WriteLine("Bread total price: " + bread.GetTotalPrice());

        List<Item> items = new()
        {
            bread,
            new Item("Milk", 1.5, 1),
            new Item("Eggs", 0.25, 6),
        };
        Console.WriteLine("\nCalling 'GetInfo()' of each item:");

        foreach (var item in items)
        {
            Console.WriteLine(item.GetInfo());
        }
    }

    private static void TestShopInventory()
    {
        List<Item> items = new()
        {
            new Item("Bread", 2.5, 1),
            new Item("Bread", 2.5, 3),
            new Item("Bread", 2.5, 5),
            new Item("Milk", 1.5, 1),
            new Item("Milk", 1.5, 1),
            new Item("Milk", 2.5, 1),
            new Item("Eggs", 0.25, 2),
            new Item("Eggs", 0.25, 4),
            new Item("Eggs", 0.25, 6),
        };

        Console.WriteLine("Adding items to the Shop...");
        foreach (var item in items)
        {
            Shop.AddItemToInventory(item);
        }
        Console.WriteLine("Done. The following items were added:");
        foreach (var item in Shop.Inventory)
        {
            Console.WriteLine(item.GetInfo());
        }
    }

    private static void TestShopBuy()
    {
        List<Item> items = new()
        {
            new Item("Bread", 2.5, 5),
            new Item("Milk", 1.5, 1),
            new Item("Milk", 1.25, 5),
            new Item("Eggs", 0.25, 2),
            new Item("Eggs", 0.25, 4),
            null,
        };

        foreach (var item in items)
        {
            Shop.AddItemToInventory(item);
        }

        List<Item> boughtItems = new()
        {
            Shop.BuyItem(null, 5, 5),
            Shop.BuyItem("Bread", 5, 12.5),
            Shop.BuyItem("Bread", 4, 12.5),
            Shop.BuyItem("Milk", 1, 1.5),
            Shop.BuyItem("Milk", 5, 6.25),
            Shop.BuyItem("Milk", 5, 6.5),
            Shop.BuyItem("Eggs", 1, 0.25),
            Shop.BuyItem("Eggs", 2, 0.5),
            Shop.BuyItem("Eggs", 4, 1),
        };

        boughtItems.RemoveAll(item => item == null);

        foreach (var item in boughtItems)
        {
            Console.WriteLine(item.GetInfo());
        }
    }
}