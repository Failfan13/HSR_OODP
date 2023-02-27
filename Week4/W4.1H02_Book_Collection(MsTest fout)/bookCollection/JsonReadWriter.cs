using Newtonsoft.Json;
class JsonReadWriter
{
    public static void WriteToJson(List<Book> listOfBooks)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("books.json"))
            {
                string toJson = "";
                try
                {
                    toJson = JsonConvert.SerializeObject(listOfBooks);
                }
                catch (JsonReaderException ex)
                {
                    Console.WriteLine($"Invalid JSON. {ex.Message}");
                    return;
                }
                writer.Write(toJson);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Missing JSON file. {ex.Message}");
        }
    }
    public static List<Book> ReadFromJson()
    {
        try
        {
            using (StreamReader reader = new("books.json"))
            {
                List<Book> listOfBooks = new();
                string jsonToText = reader.ReadToEnd();
                try
                {
                    listOfBooks.AddRange(JsonConvert.DeserializeObject<List<Book>>(jsonToText));
                }
                catch (JsonReaderException ex)
                {
                    Console.WriteLine($"Invalid JSON. {ex.Message}");
                    return listOfBooks;
                }
                return listOfBooks;
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Missing JSON file. {ex.Message}");
        }
        return null;
    }
}