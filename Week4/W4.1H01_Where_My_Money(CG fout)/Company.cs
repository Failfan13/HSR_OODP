class Company
{
    public List<Employee> Employees;
    public int WhatIsConsideredDistant;
    public int ExtraTravelAllowanceBudget;
    public int MaxExtraTravelAllowance;
    public string LogLocation;
    public Company()
    {
        Employees = new List<Employee>();
        WhatIsConsideredDistant = 25;
        ExtraTravelAllowanceBudget = 300;
        MaxExtraTravelAllowance = 100;
        LogLocation = "./Log.txt";
    }

    public void Hire(Employee employee) => Employees.Add(employee);

    public void PayMonthlySalary()
    {
        int howManyDistantEmployees = HowManyDistantEmployees();
        foreach (var employee in Employees)
        {
            int payout = employee.Salary + CalculateTravelAllowance(employee, howManyDistantEmployees);
            employee.SalaryEarned += payout;
        }
    }

    private int CalculateTravelAllowance(Employee employee, int howManyDistantEmployees)
    {
        var howManyCloseEmployees = Employees.Count - howManyDistantEmployees;
        var standardTravelAllowance = employee.DistanceFromCompany * 10;
        var extraTravelAllowanceDistant = 0;
        var extraTravelAllowanceClose = 0;

        try
        {
            extraTravelAllowanceDistant = Math.Min(ExtraTravelAllowanceBudget / howManyDistantEmployees, MaxExtraTravelAllowance);
            extraTravelAllowanceClose = Math.Min((ExtraTravelAllowanceBudget - extraTravelAllowanceDistant * howManyDistantEmployees) / howManyCloseEmployees, 100);
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
            {
                ExtraTravelAllowanceBudget -= extraTravelAllowanceDistant;
            }

            // Console.WriteLine(extraTravelAllowanceClose);
        }
        catch (DivideByZeroException ex)
        {
            string message = ex.Message;
            message =
                (howManyDistantEmployees == 0 ? "0 distant employees. " : "") +
                (howManyCloseEmployees == 0 ? "0 close employees. " : "") +
                message;
            LogException(message);
        }
        return standardTravelAllowance +
               (employee.DistanceFromCompany >= WhatIsConsideredDistant ?
               extraTravelAllowanceDistant : extraTravelAllowanceClose) +
                ExtraTravelAllowanceBudget / howManyCloseEmployees;
    }

    private int HowManyDistantEmployees()
    {
        int howMany = 0;
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
                howMany++;
        }
        return howMany;
    }

    private void LogException(string message)
    {
        try
        {
            File.AppendAllText(LogLocation, DateTime.Now + "\n" + message + "\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}