class BankAccount
{
    private double _balance;
    protected int YearsPassed;
    protected double InterestRate;

    public BankAccount(double balance, double interestRate)
    {
        _balance = balance;
        YearsPassed = 0;
        InterestRate = interestRate;
    }

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

    public virtual double Withdraw(double amount)
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

    public virtual void NextYear()
    {
        ApplyInterest();
    }

    protected void ApplyInterest()
    {
        _balance += (_balance * (InterestRate * 100)) / 100;
    }
}