public static class ContainerLogger
{
    public static Dictionary<string, Container> containerLog = new Dictionary<string, Container>();

    // public static void Log(Container container)
    // {
    //     if (!containerLog.Keys.Contains(container.Code))
    //     {
    //         containerLog.Add(container.Code, container);
    //         container.Status = ContainerStatus.Approved;
    //     }
    //     containerLog[container.Code] = container;
    //     container.Status = ContainerStatus.ApprovedAfterInspection;
    // }
    public static void Log(Container container)
    {
        if (!containerLog.Keys.Contains(container.Code))
            containerLog.Add(container.Code, container);
        else
            containerLog[container.Code] = container;
    }

    public static void Print()
    {
        foreach (KeyValuePair<string, Container> containers in containerLog)
        {
            Console.WriteLine(containers.Value.ToString());
        }
    }

    public static void GetAverageWeightDeviation(ContainerStatus stat)
    {
        var temp = ContainerLogger.containerLog.Where(i => i.Value.Status == stat).ToArray();

        Console.WriteLine("Average Deviation from containers with status '{stat}': " + Math.Round(temp.Sum(i => i.Value.Weight - i.Value.ActualWeight)), 0);
    }

    public static void GetDistinctCategories(ContainerStatus stat)
    {
        var temp = ContainerLogger.containerLog.Where(i => i.Value.Status == stat).ToArray();

        string[] cats = temp.SelectMany(c => c.Value.Categories).Distinct().ToArray();

        Console.WriteLine("Distinct categories from containers with status 'UnderReview':\n[" + String.Join(", ", cats) + "]");
    }
}