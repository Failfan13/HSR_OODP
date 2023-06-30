using System.ComponentModel;

public enum CompanyPosition
{
    [Description("CEO")]
    ChiefExecutiveOfficer,
    [Description("CTO")]
    ChiefTechnologyOfficer,
    [Description("CFO")]
    ChiefFinancialOfficer,
    Manager,
    Employee
}