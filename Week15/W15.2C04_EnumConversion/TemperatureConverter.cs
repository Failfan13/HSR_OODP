public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

public static class TemperatureConverter
{
    public static string ConvertToString(TemperatureUnit unit)
    {
        return (int)unit switch
        {
            0 => "C",
            1 => "F",
            2 => "K",
            _ => "N"
        };
    }

    public static TemperatureUnit ConvertToEnum(string letter) => letter switch
    {
        "C" => TemperatureUnit.Celsius,
        "F" => TemperatureUnit.Fahrenheit,
        "K" => TemperatureUnit.Kelvin,
        _ => throw new ArgumentException("Invalid temperature unit string")
    };
}