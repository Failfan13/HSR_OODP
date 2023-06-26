using Newtonsoft.Json;

public static class HistoricalEventSearch
{
    public static List<HistoricalEvent> ReadEvents(string dataset)
    {
        StreamReader reader = new StreamReader(dataset);
        string jsonString = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<List<HistoricalEvent>>(jsonString)!;
    }

    public static List<HistoricalEvent> SearchInDescription(List<HistoricalEvent> eventList, string search)
    {
        return eventList.FindAll(e => e.Description.Contains(search));
    }

    public static List<HistoricalEvent> SearchBetweenYears(List<HistoricalEvent> eventList, int from, int to)
    {
        return eventList.FindAll(e => e.Year >= from && e.Year <= to);
    }

    public static double AverageEventYear(List<HistoricalEvent> eventList)
    {
        return (int)eventList.Average(e => e.Year);
    }
}