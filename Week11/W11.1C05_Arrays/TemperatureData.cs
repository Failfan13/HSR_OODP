using System.Collections;

class WeatherData
{
    private readonly double[] _data;

    public int NumberOfReadings
    {
        get => _data.Length;
    }

    public WeatherData(double[] data) => _data = data;

    public double GetHighestTemperature()
    {
        return _data.Max();
    }
}