class LimitedEditionCar {
    public const string Model = "McLaren P1";

    public static int Counter;

    public readonly string ChassisNumber;

    public LimitedEditionCar() => ChassisNumber = $"CHNO{++Counter}";
}