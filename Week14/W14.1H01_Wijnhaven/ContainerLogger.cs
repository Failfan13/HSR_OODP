public static class ContainerLogger
{
    public static Dictionary<string, Container> containerLog = new Dictionary<string, Container>();

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
}