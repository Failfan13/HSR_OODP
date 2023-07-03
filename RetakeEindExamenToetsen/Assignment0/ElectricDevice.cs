public abstract class ElectricDevice : IRechargeable
{
    public string Name { get; }
    public bool IsOn { get; protected set; }
    public abstract int BatteryLevel { get; set; }

    public ElectricDevice(string name) => Name = name;

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void Display();
    public abstract void Recharge();
}