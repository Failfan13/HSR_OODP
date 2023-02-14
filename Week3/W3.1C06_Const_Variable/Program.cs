class Program {
    public static int spdOfLightInMperS = 299792458;
    public static double daysInYear = 365.242199;
    public static string planetName = "LP 890-9b";
    public static double DistanceFromEarthInLightYear = 100;

    public static void Main() {
        Console.WriteLine("The planet {0} is {1} lightyears away from earth\nIn meters this is {2}", 
            planetName, DistanceFromEarthInLightYear, CalculateDistanceByLight());
    }

    private static double CalculateDistanceByLight() {
        return (DistanceFromEarthInLightYear * 946052841054543859 / 100);
    }
}
