public interface IAccount : IEquatable<IAccount>
{
    string AccountNumber { get; }
    double Balance { get; }

    void Deposit(double balance);
    void Withdraw(double balance);
}