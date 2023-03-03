class SavingsAccount : BankAccount
{
    private bool _locked;
    public SavingsAccount(double balance, double interestRate)
        : base(balance, interestRate)
    {
        _locked = true;
    }
    public override double Withdraw(double amount)
    {
        if (_locked)
        {
            return 0;
        }
        return base.Withdraw(amount);
    }
    public override void NextYear()
    {
        base.YearsPassed++;
        if (base.YearsPassed < 5)
        {
            base.ApplyInterest();
        }
        else if (base.YearsPassed >= 5)
        {
            _locked = false;
        }
    }
}