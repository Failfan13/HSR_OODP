class LimitedEditionCar {
    public const string Model = "McLaren P1";

    public static int Counter = 1;

    public readonly string ChassisNumber = $"CHNO{Counter}";

    public LimitedEditionCar() => ++Counter;
}