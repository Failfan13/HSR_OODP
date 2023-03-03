public class Employee
{

    public string Name { get; set; }

    private double _salary;
    public double Salary
    {
        get => _salary;
        set
        {
            if (value >= 0)
            {
                _salary = value;
            }
            else
            {
                throw new ArgumentException("Salary must be non-negative.");
            }
        }
    }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual string Info()
    {
        return $"Name: {Name}; Salery: {_salary}";
    }
}