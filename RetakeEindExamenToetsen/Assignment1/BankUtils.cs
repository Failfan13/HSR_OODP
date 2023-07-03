public static class BankUtils
{
    public static void PrintAccountBalance<T>(T iets) where T : IAccount
    {
        Console.WriteLine($"Account Number: {iets.AccountNumber}\nBalance: {iets.Balance}");
    }
}