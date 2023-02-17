class CarFactory {
    public int Limited;

    public List<LimitedEditionCar> ProdCars= new List<LimitedEditionCar> ();

    public CarFactory(int num) => Limited = num;
    public LimitedEditionCar? ProduceLimitedEditionCar() {
        if (ProdCars.Count < Limited) {
            var tempCar = new LimitedEditionCar();
            ProdCars.Add(tempCar);
            return tempCar;
        } else {
            return null;
        }
        
    }
}