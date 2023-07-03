public class BankAccount : IAccount, IEquatable<IAccount>
{
    public string AccountNumber { get; set; }
    public double Balance { get; private set; } = 0;

    public BankAccount(string accNum) => AccountNumber = accNum;

    public void Deposit(double balance) => Balance += balance;

    public void Withdraw(double balance) => Balance -= balance;

    public bool Equals(IAccount? acc)
    {
        if (acc == null) return false;

        return AccountNumber == acc.AccountNumber;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is IAccount)) return false;

        return Equals(obj as IAccount);
    }
}