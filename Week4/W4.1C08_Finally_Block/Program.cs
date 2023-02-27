// using Newtonsoft.Json;

// public class Program
// {
//     public static void Main()
//     {
//         var listCars = ReadJson();

//         foreach (var ok in listCars)
//             foreach (var car in ok.OwnedCars)
//                 for (var i = 0; i < 5; i++)
//                     car.Drive();

//         WriteJson(listCars);
//     }

//     public static List<Person> ReadJson()
//     {
//         List<Person> listOfObjects = new();
//         try
//         {
//             StreamReader reader = null;
//             try
//             {
//                 reader = new(@"People.json");
//             }
//             catch (System.IO.IOException e)
//             {
//                 Console.WriteLine($"Missing JSON file. {e}");
//             }
//             finally
//             {
//                 reader.Close();
//                 reader.Dispose();
//             }
//             string jsonText = reader.ReadToEnd();
//             listOfObjects.AddRange(JsonConvert.DeserializeObject<List<Person>>(jsonText));
//         }
//         catch (Newtonsoft.Json.JsonReaderException e)
//         {
//             Console.WriteLine($"Invalid JSON. {e}");
//         }

//         return listOfObjects;
//     }

//     public static void WriteJson(List<Person> listPerson)
//     {
//         try
//         {
//             StreamWriter writer = new(@"People.json");
//             string toJson = JsonConvert.SerializeObject(listPerson);
//             writer.Write(toJson);
//             writer.Close();
//             writer.Dispose();
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e);
//         }
//     }
// }