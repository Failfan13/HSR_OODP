public class Employee : IPayable
{
    public string Name;
    public double Salary { get; set; }
    public int EmployeeId { get; set; }
    public static int EmployeeCounter = 0;

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
        EmployeeId = ++EmployeeCounter;
    }

    double IPayable.GetPaymentAmount()
    {
        return Salary;
    }

    string IPayable.Name
    {
        get => Name;
        set { }
    }

    string IPayable.Info
    {
        get => $"ID: {EmployeeId} ({Name}); {Salary}/month";
    }
}