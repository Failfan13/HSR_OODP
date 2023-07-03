public class SavingsAccount<T> : BankAccount, IComparable<IAccount>
{
    public T InterestRate { get; }

    public SavingsAccount(string accNum, T interestRate)
        : base(accNum)
    {
        InterestRate = interestRate;
    }

    public int CompareTo(IAccount? obj)
    {
        if (obj == null) return 1;

        return Balance.CompareTo(obj.Balance);
    }
}