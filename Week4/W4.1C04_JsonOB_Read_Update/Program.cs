using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        var listCars = ReadJson();

        foreach (var car in listCars)
            for (var i = 0; i < 5; i++)
                car.Mileage++;

        WriteJson(listCars);
    }

    public static List<Car> ReadJson()
    {
        StreamReader reader = new(@"Cars.Json");
        string jsonText = reader.ReadToEnd();
        List<Car> listOfObjects = JsonConvert.DeserializeObject<List<Car>>(jsonText);
        reader.Close();
        reader.Dispose();
        return listOfObjects;
    }

    public static void WriteJson(List<Car> listCars)
    {
        StreamWriter writer = new(@"Cars.Json");
        string toJson = JsonConvert.SerializeObject(listCars);
        writer.Write(toJson);
        writer.Close();
        writer.Dispose();
    }
}