using System;
using Newtonsoft.Json;
static class Calculator
{
    public static double Add(double n1, double n2)
    {
        return (n1 + n2);
    }
    public static double Subtract(double n1, double n2)
    {
        return (n1 - n2);
    }
    public static double Multiply(double n1, double n2)
    {
        return (n1 * n2);
    }
    public static double Divide(double n1, double n2)
    {
        return (n1 / n2);
    }
    public static double Modulo(double n1, double n2)
    {
        return (n1 % n2);
    }

    public static void StoreInMemory(double number)
    {
        StreamWriter writer = new StreamWriter(@"Memory.json");
        writer.Write(JsonConvert.SerializeObject(number));
        writer.Close();
        writer.Dispose();
    }

    public static double RestoreFromMemory()
    {
        StreamReader reader = new StreamReader(@"Memory.json");
        string jsonString = reader.ReadToEnd();
        reader.Close();
        reader.Dispose();
        var fromjson = JsonConvert.DeserializeObject<double>(jsonString)!;
        return fromjson;
    }
}