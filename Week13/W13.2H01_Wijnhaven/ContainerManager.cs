//using System.Text.Json;
using Newtonsoft.Json;

public static class ContainerManager
{
    public static void Start(string pathToManifest)
    {
        foreach (string Manifest in Directory.GetFiles(pathToManifest, "*.json"))
        {
            foreach (Container container in ProcessManifest(Manifest))
            {
                Console.WriteLine(container.ToString());
            };
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
}