//using System.Text.Json;
using Newtonsoft.Json;

public static class ContainerManager
{
    public static Queue<Container> selectedForInspection = new Queue<Container>();


    public static void Start(string pathToManifest)
    {
        foreach (string Manifest in Directory.GetFiles(pathToManifest, "*.json"))
        {
            MarkForInspection(ProcessManifest(Manifest), container => container.Origin == "COL" && container.Categories.Contains("Fruits"));
        }
    }

    public static List<Container> ProcessManifest(string pathManifest)
    {
        using (StreamReader sr = new StreamReader(pathManifest))
        {
            string json = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Container>>(json);
        }
    }

    public static List<Container> SearchByOrigin(List<Container> containers, string origin)
    {
        return containers.FindAll(c => c.Origin == origin);
    }

    public static Container SearchForHeaviest(List<Container> containers)
    {
        return containers.MaxBy(c => c.Weight);
    }

    public static void MarkForInspection(List<Container> containers, Func<Container, bool> filter = null!)
    {
        foreach (Container container in containers)
        {
            if (filter != null && filter(container)) // with condition
            {
                container.Status = 1;
                selectedForInspection.Enqueue(container);
            }
            else container.Status = 9;

            ContainerLogger.Log(container);
        }

        Console.WriteLine("Number of containers selected for inspection: " + selectedForInspection.Count);
    }

}