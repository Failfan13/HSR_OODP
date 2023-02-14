class Scale {
    public bool UseKg = true;

    public Scale() {}

    public static double ConvertKgToLb(double kgNum) {
        return (kgNum * 2.2);
    }

    public string DisplayWeight(double weight) {
        if (UseKg == true) {
            return $"{weight} kg";
        } else {
            return $"{ConvertKgToLb(weight)} lbs";
        }
    }
}