public class Company
{
    private List<Employee> _employees { get; } = new();
    public void HireEmployee(Employee emp) => _employees.Add(emp);

    public List<Employee> FilterEmployees(Func<Employee, bool> lamb)
    {
        List<Employee> filteredList = new List<Employee>();

        foreach (Employee emp in _employees)
        {
            if (lamb(emp))
            {
                filteredList.Add(emp);
            }
        }

        return filteredList;
    }
}