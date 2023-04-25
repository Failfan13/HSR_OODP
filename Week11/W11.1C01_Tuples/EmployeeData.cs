public class EmployeeData
{
    private readonly List<Employee> _employees;

    public EmployeeData(List<Employee> employees)
    {
        _employees = employees;
    }

    public List<double> GetSalaryRange()
    {
        double minSalary = double.MaxValue;
        double maxSalary = double.MinValue;

        foreach (Employee employee in _employees)
        {
            if (employee.Salary < minSalary)
                minSalary = employee.Salary;

            if (employee.Salary > maxSalary)
                maxSalary = employee.Salary;
        }

        return new List<double>() { minSalary, maxSalary };
    }
}