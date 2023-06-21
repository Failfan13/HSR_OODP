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

    public void Sort(bool asceOrder)
    {
        Array.Sort(_data);

        if (!asceOrder) Array.Reverse(_data);
    }

    public void PrintTemperatures()
    {
        foreach (double temp in _data)
            Console.WriteLine(temp);
    }

    public double[] GetTemperaturesSorted(bool asceOrder)
    {
        double[] dubData = new Double[_data.Length];

        Array.Copy(_data, dubData, _data.Length);

        Array.Sort(dubData);

        if (!asceOrder) Array.Reverse(dubData);

        return dubData;
    }
}