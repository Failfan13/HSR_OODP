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
//         StreamReader reader = null;
//         try
//         {
//             string jsonText = "";
//             try
//             {
//                 reader = new(@"People.json");
//                 jsonText = reader.ReadToEnd();
//             }
//             catch (FileNotFoundException e)
//             {
//                 Console.WriteLine($"Missing JSON file. {e.Message}");
//             }
//             listOfObjects.AddRange(JsonConvert.DeserializeObject<List<Person>>(jsonText));
//             reader.Close();
//             reader.Dispose();
//         }
//         catch (JsonReaderException e)
//         {
//             Console.WriteLine($"Invalid JSON. {e.Message}");
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

// /* Exceptions -> try catch:
//         /home/codegrade/student/Files/Program.cs(21,38): warning CS8600: 
//         Converting null literal or possible null value to non-nullable type. [/home/codegrade/student/Files/Files.csproj]
//         /home/codegrade/student/Files/Program.cs(24,16): warning CS8603: 
//         Possible null reference return. [/home/codegrade/student/Files/Files.csproj]
// */