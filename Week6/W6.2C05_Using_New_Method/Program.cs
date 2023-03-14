class Program
{
    public static void Main()
    {
        List<Employee> employeeList = new()
        {
            new Employee("John", "Doe", "john.doe@example.com"),
            new Manager("Jane", "Doe", "jane.doe@example.com", "Sales"),
            new SalesPerson("Bob", "Smith", "bob.smith@example.com", 100000)
        };

        foreach (var employee in employeeList)
        {
            employee.PrintEmployeeInfo();
        }

        foreach (var employee in employeeList)
        {
            if (employee is SalesPerson)
            {
                ((SalesPerson)employee).PrintEmployeeInfo();
            }
            else if (employee is Manager)
            {
                ((Manager)employee).PrintEmployeeInfo();
            }
            else
            {
                employee.PrintEmployeeInfo();
            }
        }
    }
}