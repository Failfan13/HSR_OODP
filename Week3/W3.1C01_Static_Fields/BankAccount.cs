class BankAccount {
    public static double InterestRatePercentage = 0.0;

    public double Balance = 0.0;

    public BankAccount() {}

    public void Deposit(double incr) {
        Balance += incr;
    }
    
    public void ApplyInterest() {
        Balance += Balance * InterestRatePercentage / 100;
    }
}