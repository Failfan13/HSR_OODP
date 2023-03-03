class BankAccount
{
    private double _balance;

    public BankAccount(double balance) => _balance = balance;

    public double ReadBalance()
    {
        return _balance;
    }
    public void Deposit(double amount)
    {
        if (amount >= 0)
        {
            _balance += amount;
        }
    }

    public double Withdraw(double amount)
    {
        if (!SufficientBalance(amount) || amount < 0)
        {
            return 0;
        }
        return _balance -= amount;
    }
    private bool SufficientBalance(double amount)
    {
        return _balance >= amount;
    }
}