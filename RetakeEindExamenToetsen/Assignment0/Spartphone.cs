public class Smartphone : ElectricDevice, IRechargeable, ICamera
{
    public string Generation { get; }
    private int _batteryLevel { get; set; }
    public override int BatteryLevel
    {
        get => _batteryLevel;
        // set => _batteryLevel = value;
        set
        {
            if (value < 0) _batteryLevel = 0;
            else if (value > 100) _batteryLevel = 100;
            else _batteryLevel = value;
        }
    }

    public Smartphone(string name, string generation)
        : base(name)
    {
        Generation = generation;
        base.IsOn = false;
        BatteryLevel = 0;
    }

    public override void TurnOn()
    {
        if (base.IsOn == false && BatteryLevel > 0)
        {
            base.IsOn = true;
            Console.WriteLine($"{Name} is turned on.");
        }
        else Console.WriteLine($"{Name} can not be turned on.");
    }
    public override void TurnOff()
    {
        base.IsOn = false;
        Console.WriteLine($"{Name} is turned off.");
    }

    public override void Recharge()
    {
        BatteryLevel = 100;
        Console.WriteLine($"{Name} is fully recharged.");
    }

    public override void Display()
    {
        Console.WriteLine($"DISPLAY-Name:{Name}-Generation:{Generation}-Battery Level:{BatteryLevel}");
    }

    public void TakePhoto()
    {
        if (BatteryLevel != 0)
        {
            BatteryLevel -= 1;
            Console.WriteLine($"{Name} took a photo.");
        }
        else Console.WriteLine($"{Name} can not take a photo.");
    }
}