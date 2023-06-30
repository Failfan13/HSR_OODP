using System.ComponentModel;

public class Program
{
    static void Main()
    {
        foreach (CompanyPosition position in Enum.GetValues(typeof(CompanyPosition)))
        {
            string positionDescription = GetEnumDescription(position);
            Console.WriteLine($"Position: {position}, Description: {positionDescription}");
        }
    }

    static string GetEnumDescription(Enum enumValue)
    {
        var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
        var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        if (attributes != null && attributes.Length > 0)
        {
            return attributes[0].Description;
        }

        return enumValue.ToString();
    }
}