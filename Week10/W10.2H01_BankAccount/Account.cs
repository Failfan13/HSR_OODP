using System.Collections;

public class Account : IEquatable<object>, IComparable<Account>
{
    public int AccountNumber { get; set; } = 0;
    public string AccountHolderName { get; set; } = "";
    public double Balance { get; set; } = 0;

    public bool Equals(object acc)
    {
        if (acc == null || !(acc is Account)) return false;

        var account = acc as Account;

        if (account.AccountNumber == AccountNumber &&
            account.AccountHolderName == AccountHolderName &&
            account.Balance == Balance) return true;
        return false;
    }

    public int CompareTo(Account? acc)
    {
        if (acc == null) return 1;

        int accNum = AccountNumber.CompareTo(acc.AccountNumber);//acc.AccountNumber.CompareTo(AccountNumber);
        if (accNum != 0) return accNum;

        int accName = AccountHolderName.CompareTo(AccountHolderName);//acc.AccountHolderName.CompareTo(AccountHolderName);
        if (accName != 0) return accName;

        int balance = Balance.CompareTo(acc.Balance);//acc.Balance.CompareTo(Balance);
        if (balance != 0) return balance;
        return 0;
    }
}