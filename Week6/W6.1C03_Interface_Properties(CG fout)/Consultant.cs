public class Consultant : IPayable
{
    public string Name;
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
    }

    string IPayable.Name
    {
        get => Name;
        set { }
    }
    string IPayable.Info
    {
        get => $"{Name}; {HourlyRate}/hour";
    }
    double IPayable.GetPaymentAmount()
    {
        return (HoursWorked * HourlyRate);
    }
}