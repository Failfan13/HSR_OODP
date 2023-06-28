//using Newtonsoft.Json;

public class InventoryManager
{
    public static List<Plant> DetectLowInventory(List<Plant> inventory)
    {
        return inventory.Where(p => p.Stock < 5).OrderBy(p => p.Stock).ToList();
    }

    public static List<Plant> SearchByCategory(List<Plant> inventory, string category)
    {
        return inventory.Where(p => p.Category == category).ToList();
    }

    public static List<Plant> LastSoldItems(List<Plant> inventory)
    {
        DateOnly lastSalesDate = inventory.Where(p => p.LastSold != DateOnly.MinValue).Max(p => p.LastSold);

        return inventory.Where(p => p.LastSold == lastSalesDate).ToList();
    }

    public static List<Plant> PotentialRemoval(List<Plant> inventory)
    {
        DateOnly tenMonthsAgo = DateOnly.FromDateTime(DateTime.Now.AddMonths(-10));

        return inventory.Where(p => p.LastSold <= tenMonthsAgo && p.Stock >= 10).ToList();
    }

    public static List<Plant> ReadInventory(string dataset)
    {
        string jsonString = File.ReadAllText(dataset);
        return null!;//JsonConvert.DeserializeObject<List<Plant>>(jsonString)!;
    }
}