class Program {
    public static void Main() {
        var fact = new CarFactory(3);
        for (var i = 0; i < 6;i++) {
            var tempCar = fact.ProduceLimitedEditionCar();
            Console.WriteLine((tempCar.ChassisNumber != null ? tempCar.ChassisNumber : "ok"));
        }
    }
}