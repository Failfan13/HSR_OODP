public class Car
{
    public readonly string Make;
    public readonly string Model;
    public readonly Tire[] Tires;

    public Car(string make, string model, string brand)
    {
        Make = make;
        Model = model;
        Tires = new Tire[4] {
            new Tire(brand),
            new Tire(brand),
            new Tire(brand),
            new Tire(brand)
        };
    }

    public bool TryDrive()
    {
        bool ableDrive = !Tires.Any(t => t.Durability <= 0);

        if (ableDrive)
        {
            foreach (Tire tire in Tires)
                tire.Durability--;
        }

        return ableDrive;
    }

    public void ReplaceTire(string brand, int position) => ReplaceTire(new Tire(brand), position);
    public void ReplaceTire(Tire newTire, int position)
    {
        Tires[position] = newTire;
    }

    public string GetTireInfo()
    {
        string str = "";

        for (int i = 0; i < Tires.Length; i++)
            str += $"Tire {i + 1}: Brand: {Tires[i].Brand}, Durability: {Tires[i].Durability}\n";

        return str;
    }
}