public class EmployeeData
{
    private readonly List<Employee> _employees;

    public EmployeeData(List<Employee> employees)
    {
        _employees = employees;
    }

    public (double, double) GetSalaryRange()
    {
        double minSalary = double.MinValue;
        double maxSalary = double.MaxValue;

        foreach (Employee employee in _employees)
        {
            if (employee.Salary > minSalary)
                minSalary = employee.Salary;

            if (employee.Salary < maxSalary)
                maxSalary = employee.Salary;
        }

        return (maxSalary, minSalary);
    }
}